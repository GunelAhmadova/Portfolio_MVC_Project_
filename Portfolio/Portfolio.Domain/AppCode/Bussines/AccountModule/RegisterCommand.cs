using MediatR;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc.Infrastructure;
using Portfolio.Domain.AppCode.Services;
using Portfolio.Domain.Models.Entites.Identity;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace Portfolio.Domain.AppCode.Bussines.AccountModule
{
    public class RegisterCommand :IRequest<AppUser>
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Email { get; set; }

        public string Password { get; set; }
        public string ConfirmPassword { get; set; }

        public class RegisterCommandHandler : IRequestHandler<RegisterCommand, AppUser>
        {
            private readonly UserManager<AppUser> userManager;
            private readonly RoleManager<AppRole> roleManager;
            private readonly IActionContextAccessor ctx;
            private readonly EmailService emailService;
            private readonly ICryptoService cryptoService;

            public RegisterCommandHandler(UserManager<AppUser> userManager, RoleManager<AppRole> roleManager, IActionContextAccessor ctx,EmailService emailService,
                ICryptoService cryptoService)
            {
                this.userManager = userManager;
                this.roleManager = roleManager;
                this.ctx = ctx;
                this.emailService = emailService;
                this.cryptoService = cryptoService;
            }

            public async Task<AppUser> Handle(RegisterCommand request, CancellationToken cancellationToken)
            {

                var user = await userManager.FindByEmailAsync(request.Email);


                if (user != null)
                {
                    ctx.ActionContext.ModelState.AddModelError("Email", "Bu e-poct artiq istifade olunub");
                    return null;
                }


                user = new AppUser
                {
                    Name = request.Name,
                    Surname = request.Surname,
                    Email = request.Email,
                    UserName = $"{request.Name}-{Guid.NewGuid()}".ToLower()

                };


                //var countUser = await userManager.Users.CountAsync(m=>m.UserName.StartsWith(user.UserName));
                //if (countUser > 0)
                //{
                //    user.UserName = $"{user.UserName}{countUser + 1}";
                //}

                var result= await userManager.CreateAsync(user, request.Password);

                if (!result.Succeeded)
                {
                    foreach (var item in result.Errors)
                    {
                        ctx.ActionContext.ModelState.AddModelError("Name", item.Description);
                    }
                    return /*user*/  null;
                }

                //email
                var token = await userManager.GenerateEmailConfirmationTokenAsync(user);


                string myToken = cryptoService.Encrypt($"{user.Id}-{token}", true);

                string scheme = ctx.ActionContext.HttpContext.Request.Scheme;
                string host = ctx.ActionContext.HttpContext.Request.Host.ToString();


                var url = $"{scheme}://{host}/email-confirm?token={myToken}";

                //{scheme}://{host}/email-confirm?token=1

                await emailService.SendEmailAsync(user.Email,
                    "Registration",
                    $"Qeydiyyati tamamlamaq ucun <a href='{url}'>buraya</a> kecid edin");

                return user;
            }
        } 

        }
    }

