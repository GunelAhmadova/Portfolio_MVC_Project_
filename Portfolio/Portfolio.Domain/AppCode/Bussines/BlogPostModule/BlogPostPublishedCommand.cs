using MediatR;
using Microsoft.EntityFrameworkCore;
using Portfolio.Domain.AppCode.Infrastructure;
using Portfolio.Domain.Models.DataContext;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Portfolio.Domain.AppCode.Bussines.BlogPostModule
{
   public class BlogPostPublishedCommand: IRequest<JsonResponse>
    {
        public int Id { get; set; }

        public class BlogPostPublishedCommandHandler : IRequestHandler<BlogPostPublishedCommand, JsonResponse>
        {
            private readonly PortfolioDbContext db;

            public BlogPostPublishedCommandHandler(PortfolioDbContext db)
            {
                this.db = db;
            }
            public async Task<JsonResponse> Handle(BlogPostPublishedCommand request, CancellationToken cancellationToken)
            {
                JsonResponse response = new();
                var blog = await db.BlogPosts.FirstOrDefaultAsync(b => b.Id == request.Id);
                if (blog == null)
                {
                    response.Message = "Bu post tapilmadi";
                    response.Error = true;
                    goto end;
                }
                else if (blog.DeletedDate != null)
                {

                    response.Error = true;
                       response.Message = "Bu post silindiyi ucun derc edile bilmez!";
                    goto end;

                   
                }
                if (blog.PublishDate != null)
                {
                    response.Message = "Bu post artiq derc olunub";
                    response.Error = true;
                    goto end;
                }
                blog.PublishDate = DateTime.UtcNow.AddHours(4);

                response.Message = "Post Derc olundu";
                response.Error = false;
                await db.SaveChangesAsync();

                end:
                return response;
            }
        }
    }
}
