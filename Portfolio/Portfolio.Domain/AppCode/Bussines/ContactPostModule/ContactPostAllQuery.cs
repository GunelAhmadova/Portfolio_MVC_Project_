using MediatR;
using Microsoft.EntityFrameworkCore;
using Portfolio.Domain.Models;
using Portfolio.Domain.Models.DataContext;
using Portfolio.Domain.Models.Entites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Portfolio.Domain.AppCode.Bussines.ContactPostModule
{
    public class ContactPostAllQuery: IRequest<IEnumerable<ContactPost>>
    {

        public class ContactPostAllQueryHandler : IRequestHandler<ContactPostAllQuery, IEnumerable<ContactPost>>
        {
            private readonly PortfolioDbContext db;

            public ContactPostAllQueryHandler(PortfolioDbContext db)
            {
                this.db = db;
            }
            public async Task<IEnumerable<ContactPost>> Handle(ContactPostAllQuery request, CancellationToken cancellationToken)
            {
                var data = await db.ContactPosts.Where(c => c.DeletedDate == null).ToListAsync();
                return data;
            }
        }
    }
}
