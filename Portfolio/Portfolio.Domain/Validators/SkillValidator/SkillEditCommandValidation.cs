using FluentValidation;
using Portfolio.Domain.AppCode.Bussines.SkillModule;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Portfolio.Domain.Validators.SkillValidator
{
    public class SkillEditCommandValidation : AbstractValidator<SkillEditCommand>
    {
        public SkillEditCommandValidation()
        {
            RuleFor(sl => sl.SkillName).NotEmpty().MaximumLength(64);
            RuleFor(sl => sl.Description).NotEmpty().MaximumLength(512);
            RuleFor(sl => sl.Rate).NotEmpty().LessThan(100);
        }
    }
}
