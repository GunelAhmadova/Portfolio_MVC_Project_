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
    public class RegisterCommand :IRequest<bool>
    {
        public string UserName { get; set; }

        public string Email { get; set; }

        public string Password { get; set; }
        public string ConfirmPassword { get; set; }

        public class RegisterCommandHandler : IRequestHandler<RegisterCommand, bool>
        {
            private readonly UserManager<AppUser> userManager;
            private readonly RoleManager<AppRole> roleManager;
            public RegisterCommandHandler(UserManager<AppUser> userManager, RoleManager<AppRole> roleManager)
            {
                this.userManager = userManager;
                this.roleManager = roleManager;
            }

            public async Task<bool> Handle(RegisterCommand request, CancellationToken cancellationToken)
            {
                AppUser user = new()
                {
                    UserName = request.UserName,
                    Email= request.Email,
                    
                };
                var result = await userManager.CreateAsync(user, request.Password);
                if (result.Succeeded) return true;

                return false;

            }
        }
    }
}
