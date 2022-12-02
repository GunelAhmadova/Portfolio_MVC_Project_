using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore;
using Portfolio.Domain.Models;
using Portfolio.Domain.Models.DataContext;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Portfolio.Domain.AppCode.Bussines.ServiceModule
{
    public class ServiceAllQuery:IRequest<IEnumerable<Service>>
    {
        public class ServiceAllQueryHandler : IRequestHandler<ServiceAllQuery, IEnumerable<Service>>
        {
            private readonly PortfolioDbContext db;

            public ServiceAllQueryHandler(PortfolioDbContext db)
            {
                this.db = db;
            }
            public async Task<IEnumerable<Service>> Handle(ServiceAllQuery request, CancellationToken cancellationToken)
            {
                var data = await db.Services.Where(sl => sl.DeletedDate == null).ToListAsync(cancellationToken);

                return data;
            }
        }
    }
}
