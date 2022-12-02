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
                    ctx.ActionContext.ModelState.AddModelError("email", "İstifadəçi adı və ya şifrəniz səhvdir");
                    return user;
                }
                var result = await signInManager.PasswordSignInAsync(user, request.Password, true, true);
                if (!result.Succeeded)
                {
                    ctx.ActionContext.ModelState.AddModelError("Email", "İstifadəçi adı və ya şifrəniz səhvdir");
                }


                if (result.IsLockedOut)
                {
                    ctx.ActionContext.ModelState.AddModelError("email", "5 sehv ceht etdiyiniz ucun hesabiniz mehdudlashdirilib.5 deq sonra yeniden yoxlayin");

                    return user;
                }

                return user;




            }
        }
    }
}
