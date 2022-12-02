 using MediatR;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc.Infrastructure;
using Microsoft.EntityFrameworkCore;
using Portfolio.Domain.Models.Entites.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
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

            public RegisterCommandHandler(UserManager<AppUser> userManager, RoleManager<AppRole> roleManager, IActionContextAccessor ctx)
            {
                this.userManager = userManager;
                this.roleManager = roleManager;
                this.ctx = ctx;
            }

            public async Task<AppUser> Handle(RegisterCommand request, CancellationToken cancellationToken)
            {
                AppUser user = new AppUser
                {
                    Name = request.Name,
                    Surname = request.Surname,
                    Email = request.Email,
                    UserName = $"{request.Name}.{request.Surname}".ToLower()
                   
                };
                var countUser = await userManager.Users.CountAsync(m=>m.UserName.StartsWith(user.UserName));
                if (countUser > 0)
                {
                    user.UserName = $"{user.UserName}{countUser + 1}";
                }

              var result= await userManager.CreateAsync(user, request.Password);

                if (!result.Succeeded)
                {
                    foreach (var item in result.Errors)
                    {
                        ctx.ActionContext.ModelState.AddModelError("Name", item.Description);
                    }
                }

                return user;
            }
        } 

        }
    }

