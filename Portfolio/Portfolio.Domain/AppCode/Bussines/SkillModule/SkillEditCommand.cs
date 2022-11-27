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
  public  class SkillEditCommand: IRequest<Skill>
    {
        public int Id { get; set; }
        public string SkillName { get; set; }
        public string Description { get; set; }
        public int Rate { get; set; }

        public class SkillEditCommandHandler : IRequestHandler<SkillEditCommand,Skill>
        {
            private readonly PortfolioDbContext db;

            public SkillEditCommandHandler(PortfolioDbContext db)
            {
                this.db = db;
            }


            public async Task<Skill> Handle(SkillEditCommand request, CancellationToken cancellationToken)
            {

                var data = await db.Skills.FirstOrDefaultAsync(sl => sl.Id == request.Id && sl.DeletedDate == null, cancellationToken);

                if (data == null)
                {
                    return null;
                }

                data.SkillName = request.SkillName;
                data.Description = request.Description;
                data.Rate = request.Rate;

                await db.SaveChangesAsync(cancellationToken);
                return data;
            }
        }


    }
}
