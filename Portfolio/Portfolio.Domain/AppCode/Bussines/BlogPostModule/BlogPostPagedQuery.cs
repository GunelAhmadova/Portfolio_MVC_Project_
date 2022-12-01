using MediatR;
using Portfolio.Domain.AppCode.Infrastructure;
using Portfolio.Domain.Models;
using Portfolio.Domain.Models.DataContext;
using Portfolio.Domain.Models.Entites;
using Portfolio.Domain.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Portfolio.Domain.Business.BlogPostModule
{
    public class BlogPostPagedQuery : PageableModel, IRequest<PagedViewModel<BlogPost>>
    {
        public override int PageSize
        {
            get
            {
                if (base.PageSize < 9)
                    base.PageSize = 3;

                return base.PageSize;
            }
        }

        public class BlogPostsPagedQueryHandler : IRequestHandler<BlogPostPagedQuery, PagedViewModel<BlogPost>>
        {
            private readonly PortfolioDbContext db;
           
            public BlogPostsPagedQueryHandler(PortfolioDbContext db)
            {
                this.db = db;
            }

            public async Task<PagedViewModel<BlogPost>> Handle(BlogPostPagedQuery request, CancellationToken cancellationToken)
            {
                var query = db.BlogPosts
                 .Where(m => m.DeletedDate == null)
                 .AsQueryable();
            
                    

                query = query.OrderByDescending(m => m.PublishDate);

                var data = new PagedViewModel<BlogPost>(query, request.PageIndex, request.PageSize);

                return data;
            }

           
        }
    }
}

