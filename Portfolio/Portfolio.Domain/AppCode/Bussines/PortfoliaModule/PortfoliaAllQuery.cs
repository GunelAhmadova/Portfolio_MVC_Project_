using MediatR;
using Microsoft.EntityFrameworkCore;
using Portfolio.Domain.Models;
using Portfolio.Domain.Models.DataContext;
using Portfolio.Domain.Models.Entites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Portfolio.Domain.AppCode.Bussines.PortfoliaModule
{
    public class PortfoliaAllQuery : IRequest<IEnumerable<Portfolia>>
    {


        public class PortfoliaAllQueryHandler : IRequestHandler<PortfoliaAllQuery, IEnumerable<Portfolia>>
        {
            private readonly PortfolioDbContext db;

            public PortfoliaAllQueryHandler(PortfolioDbContext db)
            {
                this.db = db;
            }



            public async Task<IEnumerable<Portfolia>> Handle(PortfoliaAllQuery request, CancellationToken cancellationToken)
            {
                var data = await db.Portfolias.Where(pr => pr.DeletedDate == null).Include(pr=>pr.Category).ToListAsync(cancellationToken);

                return data;
            }
        }
    }
}
