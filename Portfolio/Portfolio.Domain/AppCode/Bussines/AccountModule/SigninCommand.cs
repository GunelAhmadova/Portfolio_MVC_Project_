using MediatR;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc.Infrastructure;
using Portfolio.Domain.AppCode.Extension;
using Portfolio.Domain.Models.Entites.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Portfolio.Domain.AppCode.Bussines.AccountModule
{
   public class SigninCommand: IRequest<AppUser>
    {

        public string UserName { get; set; }
        public string Password { get; set; }

        public class SigninCommandHandler : IRequestHandler<SigninCommand, AppUser>
        {
            private readonly SignInManager<AppUser> signInManager;
            private readonly IActionContextAccessor ctx;

            public SigninCommandHandler(SignInManager<AppUser> signInManager, IActionContextAccessor ctx)
            {
                this.signInManager = signInManager;
                this.ctx = ctx;
            }
            public  async Task<AppUser> Handle(SigninCommand request, CancellationToken cancellationToken)
            {
                AppUser user = null;

                if (request.UserName.IsEmail())
                {
                    user = await signInManager.UserManager.FindByEmailAsync(request.UserName);
                }
                else
                {
                    user = await signInManager.UserManager.FindByNameAsync(request.UserName);
                }


                if (user == null)
                {
                    ctx.ActionContext.ModelState.AddModelError("UserName", "Istifadeci adi ve ya sifre sehvdir");

                    return null;
                }
                if (!user.EmailConfirmed)
                {
                ctx.ActionContext.ModelState.AddModelError("UserName", "Emailinizi tesdiq edin");
                    return null;
                    
                }


                var result = await signInManager.PasswordSignInAsync(user, request.Password, true, true);


                if (result.IsLockedOut)
                {
                    ctx.ActionContext.ModelState.AddModelError("UserName", "Hesabibiz kecici olaraq mehdudlashdirilib");

                    return null;
                }


                if (result.IsNotAllowed)
                {
                    ctx.ActionContext.ModelState.AddModelError("UserName", "Hesaba daxil olmaq mumkun deyil");

                    return null;
                }


                if (result.Succeeded)
                {
                    return user;
                }

               
                return null;




            }
        }
    }
}
