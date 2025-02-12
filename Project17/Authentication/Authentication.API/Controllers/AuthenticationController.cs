using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Authentication.API.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace Authentication.API.Controllers
{
    [ApiController]
    [Route("api/auth")]
    public class AuthenticationController:ControllerBase
    {
        private readonly UserManager<ApplicantUser> _userManager;
        private readonly SignInManager<ApplicantUser> _signInManager;

        public AuthenticationController(UserManager<ApplicantUser> userManager, SignInManager<ApplicantUser> signInManager)
        {
            _signInManager = signInManager;
            _userManager = userManager;
        }

        [HttpPost("sign-up")]
        public async Task<IActionResult> SignUp([FromBody] SignUpRequest request)
        {
            var user = new ApplicantUser
            {
                UserName = request.Email,
                Email = request.Email,
                FirstName = request.FirstName,
                LastName = request.LastName
            };

            var result = await _userManager.CreateAsync(user,request.Password);

            if(!result.Succeeded) return BadRequest(result.Errors);

            return Ok(new {Message="User registered successfully"});
        }


        [HttpPost("sign-in")]
        public async Task<IActionResult> SignIn([FromBody] SignInRequest request)
        {
            var user = await _userManager.FindByEmailAsync(request.Email);
            if(user == null) return Unauthorized();

            var result = await _signInManager.PasswordSignInAsync(user, request.Password, request.RememberMe, false);
            if(!result.Succeeded) return Unauthorized();
            return Ok(new {Message="User signed in successfully"});
        }

        [HttpPost("sign-out")]
        [Authorize]
        public async Task<IActionResult> SignOut()
        {
            await _signInManager.SignOutAsync();
            return Ok(new {Message="User signed out successfully"});
        }
    }
}