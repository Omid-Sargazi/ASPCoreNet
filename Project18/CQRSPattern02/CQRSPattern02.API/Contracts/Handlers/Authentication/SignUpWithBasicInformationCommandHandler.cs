using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CQRSPattern02.API.Contracts.Commands.Authentication;
using CQRSPattern02.API.Contracts.Markers;
using CQRSPattern02.API.Identity;
using FluentValidation;
using Microsoft.AspNetCore.Identity;

namespace CQRSPattern02.API.Contracts.Handlers.Authentication
{
    public class SignUpWithBasicInformationCommandHandler : ICommandHandler<SignUpWithBasicInformationCommand, SignUpWithBasicInformationCommandResponse>
    {
        private readonly UserManager<ApplicantUser> _userManager;
        private readonly IValidator<SignUpWithBasicInformationCommand> _validator;

        public SignUpWithBasicInformationCommandHandler(UserManager<ApplicantUser> userManager, 
        IValidator<SignUpWithBasicInformationCommand> validator)
        {
            _userManager = userManager;
            _validator = validator;   
        }
        public async Task<SignUpWithBasicInformationCommandResponse> Handle(SignUpWithBasicInformationCommand command, CancellationToken cancellationToken)
        {
            var validationResult = await _validator.ValidateAsync(command);
            if(!validationResult.IsValid)
            {
                return new SignUpWithBasicInformationCommandResponse
                {
                    Succeeded = false,
                    Errors = validationResult.Errors.Select(e => e.ErrorMessage)
                };
            }

            var user = new ApplicantUser
            {
                UserName = command.Email,
                Email = command.Email,
                FirstName = command.FirstName,
                LastName = command.LastName,
            };

            var result = await _userManager.CreateAsync(user, command.Password);
        }
    }
}