using MediatR;
using Microsoft.AspNetCore.Identity;
using Portfolio.Domain.Models.Entites.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Portfolio.Domain.AppCode.Bussines.AccountModule
{
   public class SignOutCommand: IRequest<bool>
    {

        public class SignOutCommandHandler : IRequestHandler<SignOutCommand, bool>
        {
            private readonly SignInManager<AppUser> signInManager;

            public SignOutCommandHandler(SignInManager<AppUser> signInManager)
            {
                this.signInManager = signInManager;
            }
            public async Task<bool> Handle(SignOutCommand request, CancellationToken cancellationToken)
            {
                await signInManager.SignOutAsync();
                return true;
            }
        }


    }
}
