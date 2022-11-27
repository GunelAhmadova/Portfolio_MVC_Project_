using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore;
using Portfolio.Domain.AppCode.DTOs.ServiceDTOs;
using Portfolio.Domain.Models.DataContext;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Portfolio.Domain.AppCode.Bussines.ServiceModule
{
    public class ServiceAllQuery:IRequest<IEnumerable<ServiceDto>>
    {
        public class ServiceAllQueryHandler : IRequestHandler<ServiceAllQuery, IEnumerable<ServiceDto>>
        {
            private readonly PortfolioDbContext db;
            private readonly IMapper mapper;

            public ServiceAllQueryHandler(PortfolioDbContext db, IMapper mapper)
            {
                this.db = db;
                this.mapper = mapper;
            }
            public async Task<IEnumerable<ServiceDto>> Handle(ServiceAllQuery request, CancellationToken cancellationToken)
            {
                var services = await db.Services.Where(s => s.DeletedDate == null).ToListAsync();

                IList<ServiceDto> serviceDtos = new List<ServiceDto>();

                foreach (var service in services)
                {
                  
                    var serviceDto = mapper.Map<ServiceDto>(service);
                    serviceDtos.Add(serviceDto);
                };

                return serviceDtos;

            }
        }
    }
}
