using MediatR;
using Microsoft.EntityFrameworkCore;
using Portfolio.Domain.Models.DataContext;
using Portfolio.Domain.Models.Entites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Portfolio.Domain.AppCode.Bussines.BlogPostModule
{
    public class BlogPostCommentAllQuery: IRequest <IEnumerable<BlogPostComment>>
    {
            public int BlogPostId { get; set; }

        public class BlogPostCommentAllQueryHandler : IRequestHandler< BlogPostCommentAllQuery, IEnumerable<BlogPostComment>>
        {
            private readonly PortfolioDbContext db;

            public BlogPostCommentAllQueryHandler(PortfolioDbContext db)
            {
                this.db = db;
            }
           

            public async Task<IEnumerable<BlogPostComment>> Handle(BlogPostCommentAllQuery request, CancellationToken cancellationToken)
            {
                var comments = await db.BlogPostComments.Where(c => c.BlogPostId == request.BlogPostId).Include(c=>c.BlogPost).Include(c=>c.AppUser).ToListAsync();
                return comments;
            }
        }
    }
}
