using FluentValidation;
using Portfolio.Domain.AppCode.Bussines.PersonModule;
using Portfolio.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Portfolio.Domain.Validators.PersonValidator
{
   public class PersonValidation: AbstractValidator<PersonEditCommand>
    {

        public PersonValidation()
        {
            RuleFor(sl => sl.Name).NotEmpty().MaximumLength(64);
            RuleFor(sl => sl.Location).NotEmpty().MaximumLength(512);
            RuleFor(sl => sl.Age).NotEmpty().LessThan(100);
        }
    }
  
}
