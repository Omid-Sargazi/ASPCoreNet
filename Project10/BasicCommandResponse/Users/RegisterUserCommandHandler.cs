using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BasicCommandResponse.Commnands;

namespace BasicCommandResponse.Users
{
    public class RegisterUserCommandHandler : CommandHandler<RegisterUserCommand, CommandResponse>
    {

        public override async Task<CommandResponse> Executer(RegisterUserCommand command, CancellationToken cancellationToken)
        {
            if(string.IsNullOrWhiteSpace(command.UserName))
            {
                return new CommandResponse
                {
                    Prefix="Error",
                    Code=400,
                    Message="Username and password cannot be empty"
                };
               Console.WriteLine($"Registering user: {command.UserName}");

            }
                return new CommandResponse
                {
                    Prefix="Success",
                    Code=200,
                    Message="User registered successfully"
                };
        }
    }
}