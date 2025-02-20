using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CQRSPattern02.API.Contracts.Commands.Authentication;
using CQRSPattern02.API.Contracts.Markers;
using CQRSPattern02.API.Identity;
using FluentValidation;
using Microsoft.AspNetCore.Identity;
using Ng.JwtTokenService.Interfaces;

namespace CQRSPattern02.API.Contracts.Handlers.Authentication
{
    public class SignInCommandHandler : ICommandHandler<SignInCommand, SignInCommandResponse>
    {
        private readonly SignInManager<ApplicantUser> _signInManager;
        private readonly ITokenService _tokenService;
        private readonly IValidator<SignInCommand> _validator;

        public SignInCommandHandler(SignInManager<ApplicantUser> signInManager, ITokenService tokenService, IValidator<SignInCommand> validator)
        {
            _signInManager = signInManager;
            _tokenService = tokenService;
            _validator = validator;
        }
        
        public async Task<SignInCommandResponse> Handle(SignInCommand command, CancellationToken cancellationToken)
        {
            var validationResult = await _validator.ValidateAsync(command);
            if(!validationResult.IsValid)   
            {
                return new SignInCommandResponse
                {
                    Succeeded = false,
                    Errors = validationResult.Errors.Select(e => e.ErrorMessage),       
                };
            }

            var result = await _signInManager.PasswordSignInAsync(
                command.Email,
                command.Password,
                command.RememberMe,
                lockoutOnFailure: false);
            
            if(!result.Succeeded)
            {
                return new SignInCommandResponse
                {
                    Succeeded = false,
                    Message = "Invalid login attempt",
                    Errors = new[] {"Invalid credentials"}
                };
            }

            var user = await _signInManager.UserManager.FindByEmailAsync(command.Email);
            var token = await _tokenService.GenerateTokenAsync(user);

            return new SignInCommandResponse
            {
                Succeeded = true,
                Message = "Login successful",
                Token = token,
            };
        }
    }
}