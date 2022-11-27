using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore;
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
  public  class ServiceEditCommand: IRequest<ServiceDto>
    {
        public ServiceDto serviceDto { get; set; }

        public class ServiceEditCommandHandler : IRequestHandler<ServiceEditCommand, ServiceDto>
        {
            private readonly PortfolioDbContext db;
            private readonly IMapper mapper;



            public ServiceEditCommandHandler(PortfolioDbContext db, IMapper mapper)
            {
                this.db = db;
                this.mapper = mapper;
            }

            public async Task<ServiceDto> Handle(ServiceEditCommand request, CancellationToken cancellationToken)
            {
                var edited = mapper.Map<Service>(request.serviceDto);
                db.Entry(edited).State = EntityState.Modified;
                await db.SaveChangesAsync();
                return request.serviceDto;

            }
        }


    }
}
