using MediatR;
using Microsoft.AspNetCore.Authentication;
using Portfolio.Domain.AppCode.Bussines.AccountModule;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace Portfolio.Domain.AppCode.Providers
{
    public class AppClaimProvider : IClaimsTransformation
    {
        static public string[] principals = null;
        private readonly IMediator mediator;

        public AppClaimProvider(IMediator mediator)
        {
            this.mediator = mediator;
        }

        public async Task<ClaimsPrincipal> TransformAsync(ClaimsPrincipal principal)
        {
            if (principal.Identity.IsAuthenticated)
            {
                var query = new ReloadAuthorityQuery
                {
                    User = principal,
                };

                await mediator.Send(query);
            }


            return principal;
        }
    }
}
