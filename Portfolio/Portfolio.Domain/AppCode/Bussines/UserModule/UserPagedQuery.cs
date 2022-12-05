using MediatR;
using Microsoft.AspNetCore.Identity;
using Portfolio.Domain.AppCode.Infrastructure;
using Portfolio.Domain.Models.Entites.Identity;
using Portfolio.Domain.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Portfolio.Domain.AppCode.Bussines.UserModule
{
public class UserPagedQuery :PageableModel, IRequest<PagedViewModel<AppUser>>
    {
        public override int PageSize
        {
            get
            {
                return base.PageSize;
            }
            set
            {
                if (value <= 15)
                {
                    base.PageSize = 15;
                }
                else
                {
                    base.PageSize = value;
                }
            }
        }

            public class UserPagedQueryHandler : PageableModel, IRequestHandler<UserPagedQuery, PagedViewModel<AppUser>>
            {


                private readonly UserManager<AppUser> userManager;

            public UserPagedQueryHandler(UserManager<AppUser> userManager)
            {
                this.userManager = userManager;
            }
                public async Task<PagedViewModel<AppUser>> Handle(UserPagedQuery request, CancellationToken cancellationToken)
                {
                   var query = userManager.Users
                       .OrderBy(m => m.EmailConfirmed)
                     .ThenByDescending(m => m.Id);
                var pagedData = new PagedViewModel<AppUser>(query, request.PageIndex, request.PageSize);
                return await Task.FromResult(pagedData);

            }
        }
    }

}

