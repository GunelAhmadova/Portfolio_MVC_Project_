
using MediatR;
using Nancy.Responses;

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
    public class ServiceRemoveCommand : IRequest<Service>
    {
        public int Id { get; set; }

        public class ServiceRemoveCommandHandler : IRequestHandler<ServiceRemoveCommand, Service>
        {
            private readonly PortfolioDbContext db;

            public ServiceRemoveCommandHandler(PortfolioDbContext db)
            {
                this.db = db;
            }

            public async Task<Service> Handle(ServiceRemoveCommand request, CancellationToken cancellationToken)
            {
                var entity = db.Services
                   .FirstOrDefault(m => m.Id == request.Id && m.DeletedDate == null);

                 entity.DeletedDate = DateTime.UtcNow.AddHours(4);
                await db.SaveChangesAsync(cancellationToken);
                return entity;
               
            }
        }
    }

}
