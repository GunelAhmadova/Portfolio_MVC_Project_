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
    public class BackgroundSingleQuery : IRequest<Background>
    {
        public int Id { get; set; }

        public class BackgroundSingleQueryHandler : IRequestHandler<BackgroundSingleQuery, Background>
        {
            private readonly PortfolioDbContext db;

            public BackgroundSingleQueryHandler(PortfolioDbContext db)
            {
                this.db = db;
            }
            public async Task<Background> Handle(BackgroundSingleQuery request, CancellationToken cancellationToken)
            {
                var Background = await db.Backgrounds.FirstOrDefaultAsync(sl => sl.Id == request.Id && sl.DeletedDate == null);

                return Background;
            }


        }
    }
}
