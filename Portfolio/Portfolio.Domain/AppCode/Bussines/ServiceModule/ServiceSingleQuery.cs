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
   public class ServiceSingleQuery: IRequest<ServiceDto>
    {
        public int Id { get; set; }

        public class ServiceSingleQueryHandler : IRequestHandler<ServiceSingleQuery, ServiceDto>
        {

            private readonly PortfolioDbContext db;
            private readonly IMapper mapper;


            public ServiceSingleQueryHandler(PortfolioDbContext db, IMapper mapper)
            {
                this.db = db;
                this.mapper = mapper;
            }
            public async Task<ServiceDto> Handle(ServiceSingleQuery request, CancellationToken cancellationToken)
            {
                var  service = await db.Services
                  .FirstOrDefaultAsync(m => m.Id == request.Id && m.DeletedDate == null, cancellationToken);
                var serviceDto = mapper.Map<ServiceDto>(service); 

                return serviceDto;
            }
        }

    }
}
