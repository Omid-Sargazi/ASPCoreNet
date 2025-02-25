using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DayEightOfBook.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace DayEightOfBook.Controllers
{
    [ApiController]
    [Route("api/roles")]
    public class RoleController:ControllerBase
    {
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly RoleManager<IdentityRole> _roleManager;   

            public RoleController(UserManager<ApplicationUser> userManager, RoleManager<IdentityRole> roleManager)
            {
                _roleManager = roleManager;
                _userManager = _userManager;
            }

            [Authorize(Roles = "Admin")]
            [HttpPost("assign")]
            public async Task<IActionResult> AssignRole([FromBody] AssignRoleModel model)
            {
                var user = await _userManager.FindByEmailAsync(model.Email);
                if(user is null) return NotFound("User not found");

                if(!await _roleManager.RoleExistsAsync(model.Role))
                    return BadRequest("Role does not exist");
                
                var result = await _userManager.AddToRoleAsync(user, model.Role);
                return result.Succeeded ? Ok($"Role {model.Role} assigned to {model.Email}") : BadRequest(result.Errors);
            }
    }
}