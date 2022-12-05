using MediatR;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Portfolio.Domain.Models.Entites.Identity;
using Portfolio.Domain.Models.Roles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Portfolio.Domain.AppCode.Bussines.UserModule
{
   public class UserAvailableRolesQuery: IRequest<IEnumerable<AvailableRole>>
    {
        public int UserId { get; set; }


        public class UserAvailableRolesQueryHandler : IRequestHandler<UserAvailableRolesQuery, IEnumerable<AvailableRole>>
        {
            private readonly UserManager<AppUser> userManager;
            private readonly RoleManager<AppRole> roleManager;

            public UserAvailableRolesQueryHandler(UserManager<AppUser> userManager, RoleManager<AppRole>roleManager)
            {
                this.userManager = userManager;
                this.roleManager = roleManager;
            }
            public async Task<IEnumerable<AvailableRole>> Handle(UserAvailableRolesQuery request, CancellationToken cancellationToken)
            {
                var user = await userManager.Users.FirstOrDefaultAsync(m => m.Id == request.UserId, cancellationToken);

              var userRoles=await userManager.GetRolesAsync(user);

                var roles = (await roleManager.Roles.ToListAsync(cancellationToken))
                           .Select(m => new AvailableRole
                           {
                               RoleName = m.Name,
                               Selected = userRoles.Contains(m.Name)
                           });


                return roles;
            }
        }
    }
}
