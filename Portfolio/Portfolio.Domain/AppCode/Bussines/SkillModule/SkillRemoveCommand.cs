﻿using MediatR;
using Microsoft.EntityFrameworkCore;
using Portfolio.Domain.Models;
using Portfolio.Domain.Models.DataContext;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Portfolio.Domain.AppCode.Bussines.ServiceModule
{
  public  class SkillRemoveCommand: IRequest <Skill>
    {
        public int Id { get; set; }
        public class SkillRemoveCommandHandler : IRequestHandler<SkillRemoveCommand, Skill>
        {
            private readonly PortfolioDbContext db;

            public SkillRemoveCommandHandler(PortfolioDbContext db)
            {
                this.db = db;
            }
            public async Task<Skill> Handle(SkillRemoveCommand request, CancellationToken cancellationToken)
            {
                var skill = await db.Skills.FirstOrDefaultAsync(sl => sl.Id == request.Id && sl.DeletedDate == null);

                  skill.DeletedDate = DateTime.UtcNow.AddHours(4);

                await db.SaveChangesAsync(cancellationToken);
                return skill;
            }

          
        }
    }
}
