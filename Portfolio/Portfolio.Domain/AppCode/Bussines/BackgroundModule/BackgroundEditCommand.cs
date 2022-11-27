using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Hosting;
using Portfolio.Domain.Models;
using Portfolio.Domain.Models.DataContext;
using Portfolio.Domain.Models.Entites;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Portfolio.Domain.AppCode.Bussines.BackgroundModule
{
    public class BackgroundEditCommand : IRequest<Background>
    {
        public int Id { get; set; }
        public string DateRange { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string BackgroundLevel { get; set; }

        public IFormFile ImageFile { get; set; }
        public string Location { get; set; }
        public string BackgroundType { get; set; }

        public class BackgroundEditCommandHandler : IRequestHandler<BackgroundEditCommand, Background>
        {

            private readonly PortfolioDbContext db;
            private readonly IHostEnvironment hostEnvironment;

            public BackgroundEditCommandHandler(PortfolioDbContext db, IHostEnvironment hostEnvironment)
            {
                this.db = db;
                this.hostEnvironment = hostEnvironment;
            }


            public async Task<Background> Handle(BackgroundEditCommand request, CancellationToken cancellationToken)
            {

                var data = await db.Backgrounds.FirstOrDefaultAsync(sl => sl.Id == request.Id && sl.DeletedDate == null, cancellationToken);

                if (data == null)
                {
                    return null;
                }

                data.Title = request.Title;
                data.Description = request.Description;
                data.DateRange = request.DateRange;
                data.Location = request.Location;
                data.BackgroundType = request.BackgroundType;

              


                await db.SaveChangesAsync(cancellationToken);
                return data;
            }
        }


    }
}
