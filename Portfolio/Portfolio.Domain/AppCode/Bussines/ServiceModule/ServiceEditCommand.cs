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


    public class ServiceEditCommand : IRequest<Service>
    {

        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public class ServiceEditCommandHandler : IRequestHandler<ServiceEditCommand, Service>
        {
            private readonly PortfolioDbContext db;

            public ServiceEditCommandHandler(PortfolioDbContext db)
            {
                this.db = db;
            }


            public async Task<Service> Handle(ServiceEditCommand request, CancellationToken cancellationToken)
            {

                var data = await db.Services.FirstOrDefaultAsync(sl => sl.Id == request.Id && sl.DeletedDate == null, cancellationToken);

                if (data == null)
                {
                    return null;
                }

                data.Id = request.Id;
                data.Title = request.Title;
                data.Description = request.Description;

                await db.SaveChangesAsync(cancellationToken);
                return data;
            }
        }


    }
}
