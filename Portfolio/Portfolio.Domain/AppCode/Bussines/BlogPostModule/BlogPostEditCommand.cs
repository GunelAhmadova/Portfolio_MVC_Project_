
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Hosting;
using Portfolio.Domain.AppCode.Extension;
using Portfolio.Domain.Models;
using Portfolio.Domain.Models.DataContext;
using Portfolio.Domain.Models.Entites;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace Portfolio.Domain.Business.BlogPostModule
{
    public class BlogPostEditCommand : IRequest<BlogPost>
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Body { get; set; }
        public string ImagePath { get; set; }
        public IFormFile ImageFile { get; set; }

        public class BlogPostEditCommandHandler : IRequestHandler<BlogPostEditCommand, BlogPost>
        {
            private readonly PortfolioDbContext db;
            private readonly IHostEnvironment env;

            public BlogPostEditCommandHandler(PortfolioDbContext db, IHostEnvironment env)
            {
                this.db = db;
                this.env = env;
            }

            public async Task<BlogPost> Handle(BlogPostEditCommand request, CancellationToken cancellationToken)
            {
                var model = await db.BlogPosts
                .FirstOrDefaultAsync(b => b.Id == request.Id
                && b.DeletedDate == null, cancellationToken);

                if (model == null)
                {
                    return null;
                }
                model.Title = request.Title;
                model.Body = request.Body;

                if (request.ImageFile == null)
                    goto save;

                string newImageName = request.ImageFile.GetRandomImagePath("blog");

                await env.SaveAsync(request.ImageFile, newImageName, cancellationToken);

                env.ArchiveImage(model.ImagePath);

                model.ImagePath = newImageName;

            save:
           await db.SaveChangesAsync(cancellationToken);

                return model;
            }
        }
    }
}
