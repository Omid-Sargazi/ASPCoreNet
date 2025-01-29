using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DeepCopyWebAPI.Models;
using Microsoft.AspNetCore.Mvc;

namespace DeepCopyWebAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class UserController:ControllerBase
    {
        [HttpGet("{id}")]
        public IActionResult GetUser()
        {
            // Simulating database fetch
            User user = new User
            {
                Name = "Omid",
                Email = "Omid@examole.com",
                Profile = new Profile{Address = "New York"} 
            };
             // Convert to DTO and perform deep copy
            UserDto userDto = new UserDto
            {
                Name = user.Name,
                Email = user.Email,
                Profile = new ProfileDto {Address = user.Profile.Address},
            };

            userDto.Email = "******@example.com";

            return Ok(userDto);
        }
    }
}