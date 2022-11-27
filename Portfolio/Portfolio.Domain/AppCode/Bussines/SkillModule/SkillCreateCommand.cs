using MediatR;
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
   public class SkillCreateCommand: IRequest<Skill>
    {
        public string SkillName { get; set; }
        public string Description { get; set; }
        public int Rate { get; set; }
        public string SkillType { get; set; }



        public class SkillCreateCommandHandler:IRequestHandler<SkillCreateCommand, Skill>
        {
            private readonly PortfolioDbContext db;

            public SkillCreateCommandHandler(PortfolioDbContext db)
            {
                this.db = db;
            }
            public async Task<Skill> Handle(SkillCreateCommand request, CancellationToken cancellationToken)
            {
                var skill = new Skill()
                {
                    SkillName=request.SkillName,
                    Description=request.Description,
                    Rate=request.Rate,
                    SkillType= request.SkillType
                };

                await db.Skills.AddAsync(skill, cancellationToken);
                await db.SaveChangesAsync();
                return skill;
            }
        }
    }
}
