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

namespace Portfolio.Domain.AppCode.Bussines.BackgroundModule
{
    public class BackgroundAllQuery : IRequest<IEnumerable<Background>>
    {


        public class BackgroundAllQueryHandler : IRequestHandler<BackgroundAllQuery, IEnumerable<Background>>
        {
            private readonly PortfolioDbContext db;

            public BackgroundAllQueryHandler(PortfolioDbContext db)
            {
                this.db = db;
            }



            public async Task<IEnumerable<Background>> Handle(BackgroundAllQuery request, CancellationToken cancellationToken)
            {
                var data = await db.Backgrounds.Where(sl => sl.DeletedDate == null).ToListAsync(cancellationToken);

                return data;
            }
        }
    }
}
