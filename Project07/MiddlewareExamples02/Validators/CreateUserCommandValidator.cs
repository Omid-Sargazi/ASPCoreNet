using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FluentValidation;
using MiddlewareExamples02.Requests;

namespace MiddlewareExamples02.Validators
{
    public class CreateUserCommandValidator:AbstractValidator<CreateUserCommand>
    {
        public CreateUserCommandValidator()
        {
            RuleFor(x=>x.Name).NotEmpty().WithMessage("Name is required");
            RuleFor(x=>x.Email).EmailAddress().WithMessage("Invalid email address");
        }
    }
}