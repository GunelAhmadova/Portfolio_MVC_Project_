using AutoMapper;
using MediatR;
using Portfolio.Domain.AppCode.DTOs.ServiceDTOs;
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
   public class ServiceCreateCommand:IRequest<ServiceDto>
    { 
        public ServiceDto serviceDto { get; set; }

        public class ServiceCreateCommandHandler : IRequestHandler<ServiceCreateCommand, ServiceDto>
        {
            private readonly PortfolioDbContext db;
            private readonly IMapper mapper;


            public ServiceCreateCommandHandler(PortfolioDbContext db, IMapper mapper)
            {
                this.db = db;
                this.mapper = mapper;
                
            }
            public async Task<ServiceDto> Handle(ServiceCreateCommand request, CancellationToken cancellationToken)
            {
              var serviceChange = mapper.Map<Service>(request.serviceDto);
              await  db.Services.AddAsync(serviceChange);
              await  db.SaveChangesAsync();
                return request.serviceDto;
            }
        }

    }
}
