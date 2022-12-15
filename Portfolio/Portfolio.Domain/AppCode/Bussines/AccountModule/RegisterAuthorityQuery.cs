using MediatR;
using Microsoft.EntityFrameworkCore;
using Portfolio.Domain.AppCode.Providers;
using Portfolio.Domain.Models.DataContext;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Portfolio.Domain.AppCode.Bussines.AccountModule
{
    public class ReloadAuthorityQuery : IRequest<bool>
    {
        public ClaimsPrincipal User { get; set; }
        public class ReloadAuthorityQueryHandler : IRequestHandler<ReloadAuthorityQuery, bool>
        {
            private readonly PortfolioDbContext db;

            public ReloadAuthorityQueryHandler(PortfolioDbContext db)
            {
                this.db = db;
            }
            public async Task<bool> Handle(ReloadAuthorityQuery request, CancellationToken cancellationToken)
            {
                var userId = Convert.ToInt32(request.User.Claims.FirstOrDefault(c => c.Type.Equals(ClaimTypes.NameIdentifier)).Value);

                if (request.User.Identity is ClaimsIdentity ci)
                {
                    var currentClaims = await (from ur in db.UserRoles
                                               join rc in db.RoleClaims on ur.RoleId equals rc.RoleId
                                               where ur.UserId == userId && rc.ClaimValue.Equals("1")
                                               select rc.ClaimType)

                    .Union(from uc in db.UserClaims
                           where uc.UserId == userId && uc.ClaimValue.Equals("1")
                           select uc.ClaimType)

                    .Distinct()
                    .ToArrayAsync(cancellationToken);

                    var excepted = (from p in (AppClaimProvider.principals ?? new string[] { })
                                    join c in ci.Claims on p equals c.Type
                                    select c.Type)
                    .Except(currentClaims);

                    var claims = ci.Claims.Where(c => excepted.Contains(c.Type))
                        .ToArray();

                    foreach (var claim in claims)
                    {
                        ci.RemoveClaim(claim);
                    }

                    excepted = currentClaims.Except(from p in (AppClaimProvider.principals ?? new string[] { })
                                                    join c in ci.Claims on p equals c.Type
                                                    select c.Type);

                    foreach (var claimName in excepted)
                    {
                        ci.AddClaim(new Claim(claimName, "1"));
                    }
                    var user =await db.Users.Where(u=>u.Id==userId).FirstOrDefaultAsync();

                    ci.AddClaim(new Claim("Fullname",$"{user.Name+" " +user.Surname}"));
                }
                return true;
            }
        }
    }
}

