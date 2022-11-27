using MediatR;
using Microsoft.AspNetCore.Http;
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
   public class BackgroundCreateCommand: IRequest<Background>
    {
        public string DateRange { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string ImageUrl { get; set; }
        public string Location { get; set; }
        public string BackgroundType { get; set; }
        public string BackgroundLevel { get; set; }
        public IFormFile ImageFile { get; set; }


        public class BackgroundCreateCommandHandler:IRequestHandler<BackgroundCreateCommand, Background>
        {
            private readonly PortfolioDbContext db;
            private readonly IHostEnvironment hostEnvironment;


            public BackgroundCreateCommandHandler(PortfolioDbContext db, IHostEnvironment hostEnvironment)
            {
                this.db = db;
                this.hostEnvironment = hostEnvironment;
            }
            public async Task<Background> Handle(BackgroundCreateCommand request, CancellationToken cancellationToken)
            {
                var Background = new Background()
                {
                    Title=request.Title,
                    Description=request.Description,
                    DateRange=request.DateRange,
                    ImageUrl=request.ImageUrl,
                    Location=request.Location,
                    BackgroundType=request.BackgroundType,
                    BackgroundLevel = request.BackgroundLevel
                    

                };


                string extension = Path.GetExtension(request.ImageFile.FileName);//.jpg,.jpeg,
                string newName = Guid.NewGuid().ToString();
                Background.ImageUrl = newName + extension;
                string fullname = Path.Combine(hostEnvironment.ContentRootPath, "wwwroot", "uploads", "images", Background.ImageUrl);

                using (var fs = new FileStream(fullname, FileMode.Create, FileAccess.Write))
                {
                    request.ImageFile.CopyTo(fs);
                }

                await db.Backgrounds.AddAsync(Background, cancellationToken);
                await db.SaveChangesAsync();
                return Background;
            }
        }
    }
}
