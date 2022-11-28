using MediatR;
using Microsoft.EntityFrameworkCore;
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
  public  class PortfoliaSingleQuery: IRequest <Portfolia>
    {

        public int Id { get; set; }
        
        public class PortfoliaSingleQueryHandler : IRequestHandler<PortfoliaSingleQuery, Portfolia>
        {
            private readonly PortfolioDbContext db;

            public PortfoliaSingleQueryHandler(PortfolioDbContext db)
            {
                this.db = db;
            }

            public async Task<Portfolia> Handle(PortfoliaSingleQuery request, CancellationToken cancellationToken)
            {
                var portfolia = await db.Portfolias.Where(pr => pr.Id == request.Id).Include(pr => pr.Category).FirstOrDefaultAsync();
                return portfolia;
            }
        }
    }
}
