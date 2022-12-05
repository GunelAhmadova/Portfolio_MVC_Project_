using MediatR;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Portfolio.Domain.Models.Entites.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Portfolio.Domain.AppCode.Bussines.UserModule
{
   public class UserDetailQuery: IRequest <AppUser>
    {

        public int Id { get; set; }

        public class UserDetailQueryHandler : IRequestHandler<UserDetailQuery, AppUser>
        {
            private readonly UserManager<AppUser> userManager;

            public UserDetailQueryHandler(UserManager<AppUser> userManager)
            {
                this.userManager = userManager;
            }
            public async Task<AppUser> Handle(UserDetailQuery request, CancellationToken cancellationToken)
            {
                var data = await userManager.Users.FirstOrDefaultAsync(m => m.Id == request.Id, cancellationToken);
                return data;
            }
        }
    }
}
