using FluentValidation;
using Portfolio.Domain.AppCode.DTOs.PersonDTOs;

namespace Portfolio.Domain.Validators.PersonValidator
{
    public class PersonDtoValidator: AbstractValidator<PersonDto>
    {
        public PersonDtoValidator()
        {
            RuleFor(m => m.Name)
                .NotEmpty()
                .WithMessage("Marka adi qeyd edilmeyib")
                .MaximumLength(64);
            RuleFor(m => m.Age).GreaterThanOrEqualTo(18);
        }
    }
}
