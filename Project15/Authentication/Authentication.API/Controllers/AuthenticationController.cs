using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Authentication.API.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace Authentication.API.Controllers
{
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

            var result = await _userManager.CreateAsync(user, request.Password);
            if (!result.Succeeded) return BadRequest(result.Errors);

            return Ok(new {Message="User registered successfully"});
        }
    }
}