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
   public class ServiceSingleQuery: IRequest<Service>
    {
        public int Id { get; set; }

        public class ServiceSingleQueryHandler : IRequestHandler<ServiceSingleQuery, Service>
        {

            private readonly PortfolioDbContext db;


            public ServiceSingleQueryHandler(PortfolioDbContext db)
            {
                this.db = db;
            }
            public async Task<Service> Handle(ServiceSingleQuery request, CancellationToken cancellationToken)
            {
                var  service = await db.Services
                  .FirstOrDefaultAsync(m => m.Id == request.Id && m.DeletedDate == null, cancellationToken);
               

                return service;
            }
        }

    }
}
