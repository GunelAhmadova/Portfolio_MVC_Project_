using BigOn.Domain.Models.DataContexts;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Hosting;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Portfolio.Domain.Models;
using Portfolio.Domain.Models.DataContext;
using Portfolio.Domain.AppCode.Extension;
using Portfolio.Domain.Models.Entites;

namespace BigOn.Domain.Business.BlogPostModule
{
    public class BlogPostCreateCommand : IRequest<BlogPost>
    {
        public string Title { get; set; }
        public string Body { get; set; }
      
        public IFormFile ImageFile { get; set; }

       
        public class BlogPostCreateCommandHandler : IRequestHandler<BlogPostCreateCommand, BlogPost>
        {
            private readonly PortfolioDbContext db;
            private readonly IHostEnvironment env;

            public BlogPostCreateCommandHandler(PortfolioDbContext db, IHostEnvironment env)
            {
                this.db = db;
                this.env = env;
            }

            public async Task<BlogPost> Handle(BlogPostCreateCommand request, CancellationToken cancellationToken)
            {
                var model = new BlogPost()
                {
                    Title = request.Title,
                    Body = request.Body,
                  
                };

                model.ImagePath = request.ImageFile.GetRandomImagePath("blog");

                await env.SaveAsync(request.ImageFile, model.ImagePath, cancellationToken);

                model.Slug = model.Title.ToSlug();

                await db.AddAsync(model, cancellationToken);
                await db.SaveChangesAsync(cancellationToken);

                return model;
            }
        }
    }
}
