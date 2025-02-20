using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FluentValidation;

namespace CQRSPattern02.API.Contracts.Commands.Authentication
{
    public class SignUpWithBasicInformationCommandValidator:AbstractValidator<SignUpWithBasicInformationCommand>
    {
        public SignUpWithBasicInformationCommandValidator()
        {
            RuleFor(x => x.Email)
            .NotEmpty()
            .EmailAddress();

            RuleFor(x => x.Password)
            .NotEmpty()
            .MinimumLength(6);

            RuleFor(x => x.FirstName)
            .NotEmpty()
            .MaximumLength(50);

            RuleFor(x => x.LastName)
            .NotEmpty()
            .MaximumLength(50);   
        }   
    }
}