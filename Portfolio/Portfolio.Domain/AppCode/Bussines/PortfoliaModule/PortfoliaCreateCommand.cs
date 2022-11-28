using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Hosting;
using Portfolio.Domain.Models.DataContext;
using Portfolio.Domain.Models.Entites;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Portfolio.Domain.AppCode.Bussines.PortfoliaModule
{
   public class PortfoliaCreateCommand: IRequest<Portfolia>
    {

        public string Title { get; set; }
        public IFormFile ImageFile { get; set; }
        public string ProjectLink { get; set; } 
        public int CategoryId { get; set; }


        public class PortfoliaCreateCommandHandler : IRequestHandler<PortfoliaCreateCommand, Portfolia>
        {
            private readonly PortfolioDbContext db;
            private readonly IHostEnvironment hostEnvironment;
            public PortfoliaCreateCommandHandler(PortfolioDbContext db, IHostEnvironment hostEnvironment)
            {
                this.db = db;
                this.hostEnvironment = hostEnvironment;
            }

            public async Task<Portfolia> Handle(PortfoliaCreateCommand request, CancellationToken cancellationToken)
            {

                var portfolia = new Portfolia
                {
                    Title = request.Title,
                    ProjectLink = request.ProjectLink,
                    CategoryId = request.CategoryId
                };


                string extension = Path.GetExtension(request.ImageFile.FileName);//.jpg,.jpeg,
                string newName = Guid.NewGuid().ToString();
                portfolia.ImageUrl = newName + extension;
                string fullname = Path.Combine(hostEnvironment.ContentRootPath, "wwwroot", "uploads", "images", portfolia.ImageUrl);

                using (var fs = new FileStream(fullname, FileMode.Create, FileAccess.Write))
                {
                    request.ImageFile.CopyTo(fs);
                }




                await db.Portfolias.AddAsync(portfolia, cancellationToken);
                await db.SaveChangesAsync();

                return portfolia;
            }
        }
    }
}
