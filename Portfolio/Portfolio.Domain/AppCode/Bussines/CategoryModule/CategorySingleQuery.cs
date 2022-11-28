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

namespace BigOn.Domain.Business.CategoryModule
{
    public class CategorySingleQuery : IRequest<Category>
    {
        public int Id { get; set; } 


        public class CategorySingleQueryHandler : IRequestHandler<CategorySingleQuery, Category>
        {
            private readonly PortfolioDbContext db;

            public CategorySingleQueryHandler(PortfolioDbContext db)
            {
                this.db = db;
            }

            public async Task<Category> Handle(CategorySingleQuery request, CancellationToken cancellationToken)
            {
                var entity = await db.Categories
                   .FirstOrDefaultAsync(m => m.Id == request.Id && m.DeletedDate == null, cancellationToken);

                return entity;
            }
        }
    }
}
