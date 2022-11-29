using MediatR;
using Microsoft.EntityFrameworkCore;
using Nancy.Responses;
using Portfolio.Domain.Models;
using Portfolio.Domain.Models.DataContext;
using Portfolio.Domain.Models.Entites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Portfolio.Domain.Business.BlogPostModule
{
    public class BlogPostRemoveCommand : IRequest<BlogPost>
    {
        public int Id { get; set; }

        public class BlogPostRemoveCommandHandler : IRequestHandler<BlogPostRemoveCommand, BlogPost>
        {
            private readonly PortfolioDbContext db;

            public BlogPostRemoveCommandHandler(PortfolioDbContext db)
            {
                this.db = db;
            }
            public async Task<BlogPost> Handle(BlogPostRemoveCommand request, CancellationToken cancellationToken)
            {
                var blog = await db.BlogPosts.FirstOrDefaultAsync(sl => sl.Id == request.Id && sl.DeletedDate == null);

                blog.DeletedDate = DateTime.UtcNow.AddHours(4);

                await db.SaveChangesAsync(cancellationToken);

                return blog;
            }

           
        }
    }
}
