using Microsoft.AspNetCore.Identity;
using CleanArchitectureExample.Application.Features.Users.Commands;
using MediatR;


namespace CleanArchitectureExample.Application.Features.Users.Handlers
{
    public class CreateUserCommandHandler : IRequestHandler<CreateUserCommand, string>
    {
        private readonly UserManager<IdentityUser> _userManager;

        public CreateUserCommandHandler(UserManager<IdentityUser> userManager)
        {
            _userManager = userManager;
        }
        public async Task<string> Handle(CreateUserCommand request, CancellationToken cancellationToken)
        {
            var user = new IdentityUser
            {
                UserName = request.UserName,
                Email = request.Email
            };

            var result = await _userManager.CreateAsync(user, request.Password);
            if(!result.Succeeded)
                throw new Exception("Failed to create user.");
            return user.Id;
        }
    }

}
