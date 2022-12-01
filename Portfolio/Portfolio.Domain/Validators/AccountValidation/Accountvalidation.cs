using FluentValidation;
using Portfolio.Domain.AppCode.Bussines.AccountModule;
using Portfolio.Domain.Models.Entites.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Portfolio.Domain.Validators.AccountValidation
{
   public class Accountvalidator: AbstractValidator<RegisterCommand>
    {
        public Accountvalidator()
        {
            RuleFor(a => a.Email).NotNull();
            RuleFor(a => a.Password).NotEmpty();
            RuleFor(a => a.UserName).NotEmpty();
        }
    }
}
