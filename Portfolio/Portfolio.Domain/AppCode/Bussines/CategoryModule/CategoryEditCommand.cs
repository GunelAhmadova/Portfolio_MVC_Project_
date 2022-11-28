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

namespace Portfolio.Domain.AppCode.Bussines.CategoryModule
{
    public class CategoryEditCommand : IRequest<Category>
    { 

      
        public int Id { get; set; }
        public string Name { get; set; }

        public class CategoryEditCommandHandler : IRequestHandler<CategoryEditCommand, Category>
        {
            private readonly PortfolioDbContext db;

            public CategoryEditCommandHandler(PortfolioDbContext db)
            {
                this.db = db;
            }

            public async Task<Category> Handle(CategoryEditCommand request, CancellationToken cancellationToken)
            {
                var category = await db.Categories.FirstOrDefaultAsync(c => c.Id == request.Id && c.DeletedDate == null, cancellationToken);

                if (category == null)
                {
                    return null;
                } 

                category.Id = request.Id;
                category.Name = request.Name;

                await db.SaveChangesAsync(cancellationToken);

                return category;
            } 
        }
    }
}
