using FluentValidation;
using Portfolio.Domain.AppCode.DTOs.ServiceDTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Portfolio.Domain.Validators.ServiceValidator
{
   public class ServiceDtoValidation : AbstractValidator<ServiceDto>
    {
        public ServiceDtoValidation()
        {
            RuleFor(sr => sr.Title).NotEmpty().MaximumLength(64);
            RuleFor(sr => sr.Description).NotEmpty().MaximumLength(512);
        }
    }
}
