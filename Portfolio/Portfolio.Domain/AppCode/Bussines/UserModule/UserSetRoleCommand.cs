using MediatR;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Portfolio.Domain.AppCode.Infrastructure;
using Portfolio.Domain.Models.Entites.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Portfolio.Domain.AppCode.Bussines.UserModule
{
   public  class UserSetRoleCommand : IRequest<JsonResponse>
    {
        public int UserId { get; set; }
        public string RoleName { get; set; }
        public bool Selected { get; set; }

        public class UserSetRoleCommandHandler : IRequestHandler<UserSetRoleCommand, JsonResponse>
        {

            private readonly UserManager<AppUser> userManager;
            private readonly RoleManager<AppRole> roleManager;

            public UserSetRoleCommandHandler(UserManager<AppUser> userManager, RoleManager<AppRole> roleManager)
            {
                this.userManager = userManager;
                this.roleManager = roleManager;
            }
            public async Task<JsonResponse> Handle(UserSetRoleCommand request, CancellationToken cancellationToken)
            {
                
                var response = new JsonResponse
                {
                    Error = false
                };
                var user = await userManager.Users.FirstOrDefaultAsync(m => m.Id == request.UserId);


                if (user == null)
                {
                    response.Message = "Istifadeci movcud deyil";
                    response.Error = true;
                    goto end;
                }
                else if (user.EmailConfirmed == false)
                {
                    response.Error = true;
                    response.Message = "İstifadəçi hesabı təsdiq etməyib";
                    goto end;
                }
                if (!await roleManager.RoleExistsAsync(request.RoleName))
                {
                    response.Error = true;
                    response.Message = $"{request.RoleName} mövcud deyil";
                    goto end;
                }
                if (request.Selected && await userManager.IsInRoleAsync(user,request.RoleName))
                {
                    response.Error = true;
                    response.Message = $"`{user.Name} {user.Surname}` artiq {request.RoleName} roldadir";
                    goto end;
                }
                else if  (!request.Selected && !await userManager.IsInRoleAsync(user, request.RoleName))
                    {
                        response.Error = true;
                        response.Message = $"`{user.Name} {user.Surname}` {request.RoleName} rolda deyil";
                        goto end;
                    } 

                if (request.Selected)
                {
                    await userManager.AddToRoleAsync(user, request.RoleName);
                    response.Message = $"`{user.Name} {user.Surname}` {request.RoleName}`a əlavə edildi";
                }
                else
                {
                    await userManager.RemoveFromRoleAsync(user, request.RoleName);
                    response.Message = $"`{user.Name} {user.Surname}` {request.RoleName}`dan çıxarıldı";
                }

                end:
                return response;
            }
        }
    }
}
