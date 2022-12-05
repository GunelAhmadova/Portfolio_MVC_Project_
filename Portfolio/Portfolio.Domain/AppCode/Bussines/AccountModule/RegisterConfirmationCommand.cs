 using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Infrastructure;
using Microsoft.EntityFrameworkCore;
using Portfolio.Domain.AppCode.Services;
using Portfolio.Domain.Models.Entites.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;

namespace Portfolio.Domain.AppCode.Bussines.AccountModule
{
    public class RegisterConfirmationCommand :IRequest<AppUser>
    {
        public string Token { get; set; }
       

        public class RegisterConfirmationCommandHandler : IRequestHandler<RegisterConfirmationCommand, AppUser>
        {
            private readonly UserManager<AppUser> userManager;
            private readonly ICryptoService cryptoService;
            private readonly IActionContextAccessor ctx;


            public RegisterConfirmationCommandHandler(UserManager<AppUser> userManager, ICryptoService cryptoService,
                IActionContextAccessor ctx)
            {
                this.userManager = userManager;
                this.cryptoService = cryptoService;
                this.ctx = ctx;
            }

            public async Task<AppUser> Handle(RegisterConfirmationCommand request, CancellationToken cancellationToken)
            {
                var plainToken = cryptoService.Decrypt(request.Token);

                var match = Regex.Match(plainToken, @"(?<id>\d+)-(?<token>.+)");

                if (!match.Success)
                {
                    ctx.ActionContext.ModelState.AddModelError("Token", "Token zedelenib");
                    return null;
                }

                string token = match.Groups["token"].Value;

                var user = await userManager.FindByIdAsync(match.Groups["id"].Value);

                if (user == null)
                {
                    ctx.ActionContext.ModelState.AddModelError("Token", "Istifadeci movcud deyil!");
                    return null;
                }
                else if (user.EmailConfirmed)
                {
                    ctx.ActionContext.ModelState.AddModelError("Token", "Istifadeci artiq tesdiq edilib!");
                    return null;
                }
                var response = await userManager.ConfirmEmailAsync(user, token);

                if (!response.Succeeded)
                {
                    foreach (var error in response.Errors)
                    {
                        ctx.ActionContext.ModelState.AddModelError("Token", error.Description);
                    }

                    return null;
                }


                return user;

            }


        } 

        }
    }

