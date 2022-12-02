using AutoMapper;
using MediatR;
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
    public class ServiceCreateCommand : IRequest<Service>
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }



        public class ServiceCreateCommandHandler : IRequestHandler<ServiceCreateCommand,Service>
        {
            private readonly PortfolioDbContext db;

            public ServiceCreateCommandHandler(PortfolioDbContext db)
            {
                this.db = db;
            }
            public async Task<Service> Handle(ServiceCreateCommand request, CancellationToken cancellationToken)
            {
                var service = new Service()
                {
                    Id = request.Id,
                    Title=request.Title,
                    Description=request.Description
                };

                await db.Services.AddAsync(service, cancellationToken);
                await db.SaveChangesAsync();
                return service;
            }

            
        }
    }
}
