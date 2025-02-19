using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ECommerce.Entities;
using ECommerce.User;
using MediatR;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ECommerce.Controllers
{
    [ApiController]
    [Route("api/auth")]
    public class AuthController:ControllerBase
    {
        private readonly IMediator _mediator;
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly TokenService _tokenService;
        
        public AuthController(IMediator mediator, UserManager<ApplicationUser> userManager, TokenService tokenService)
        {
            _mediator = mediator;
            _userManager = userManager;
            _tokenService = tokenService;   
        }

        [HttpPost("register")]
        public async Task<IActionResult> Register(RegisterUserCommand command)
        {
            var result = await _mediator.Send(command);
            return Ok(result);
        }

        [HttpGet("profile/{userId}")]
        public async Task<IActionResult> GetUserProfile(string userId)
        {
            var result = await _mediator.Send(new GetUserProfileQuery(userId));
            return result == null ? NotFound("User not found"):Ok(result);
        }
    }
}