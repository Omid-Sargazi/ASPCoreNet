using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FluentValidation;
using MiddlewareExamples03.Commands;

namespace MiddlewareExamples03.Validators
{
    public class AddCustomerCommandValidator:AbstractValidator<AddCustomerCommand>
    {
        public AddCustomerCommandValidator()
        {
            RuleFor(x => x.FirstName).NotEmpty().WithMessage("First Name is required.");
            RuleFor(x => x.LastName).NotEmpty().WithMessage("Last Name is required.");
            RuleFor(x => x.Email).EmailAddress().WithMessage("Invalid Email format.");
             RuleFor(x => x.Phone).Matches(@"^\+?\d{10,15}$").WithMessage("Invalid Phone number.");
        }
    }
}