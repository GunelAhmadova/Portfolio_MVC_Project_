using MediatR;
using Microsoft.EntityFrameworkCore;
using Portfolio.Domain.Models;
using Portfolio.Domain.Models.DataContext;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Portfolio.Domain.AppCode.Bussines.SkillModule
{
   public class SkillAllQuery: IRequest<IEnumerable<Skill>>
    {
        

        public class SkillAllQueryHandler : IRequestHandler<SkillAllQuery, IEnumerable<Skill>>
        {
            private readonly PortfolioDbContext db;

            public SkillAllQueryHandler(PortfolioDbContext db)
            {
                this.db = db;
            }



            public async Task<IEnumerable<Skill>> Handle(SkillAllQuery request, CancellationToken cancellationToken)
            {
                var data = await db.Skills.Where(sl => sl.DeletedDate == null).ToListAsync(cancellationToken);

                return data;
            }
        }
    }
}
