using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using APIAuthenticationTest.API.Contracts;
using APIAuthenticationTest.API.Interfaces;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace APIAuthenticationTest.API.Controllers
{
    [ApiController]
    [AllowAnonymous]
    [Route("api/v1/authentication")]
    public class AuthenticationController:ControllerBase
    {
        private readonly IDistributor _distributor;

        public AuthenticationController(IDistributor distributor)
        {
            _distributor = distributor;   
        }   

        [HttpPost("sign-up")]
        public async Task<IActionResult> SignUp(SignUpCommand command, CancellationToken cancellationToken)
        {
            var result = await _distributor.PushCommand<SignUpCommand, SignUpCommandResponse>(command, cancellationToken);
            return Ok(result);
        }

        [HttpPost("sign-in")]
        public async Task<IActionResult> signIn(SignInCommand command, CancellationToken cancellationToken)
        {
            var result = await _distributor.PushCommand<SignInCommand, SignInCommandRespons>(command, cancellationToken);
            return Ok(result);
        }

        [HttpGet("sign-out")]
        public async Task<IActionResult> SignOut(CancellationToken cancellationToken)
        {
            var result = await _distributor.PushCommand<SignOutCommand, SignOutCommandResponse>(new SignOutCommand(), cancellationToken);
            return Ok(result);
        }
    }
}