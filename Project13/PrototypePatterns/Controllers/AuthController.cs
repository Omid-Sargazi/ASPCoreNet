using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity.Data;
using Microsoft.AspNetCore.Mvc;
using PrototypePatterns.Mangers;
using PrototypePatterns.Models;

namespace PrototypePatterns.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class AuthController:ControllerBase
    {
        private readonly SessionManager _sessionManager;

        public AuthController(SessionManager sessionManager)
        {
            _sessionManager = sessionManager;
        }

        public IActionResult Login([FromBody] LoginsRequest request)
        {
            if(request.UserName == "JohnDoe" && request.Password =="Password")
            {
                var session = _sessionManager.CreateSession(
                    request.UserName,
                    new List<string>{"Admin","Editor"},
                    new Dictionary<string, string>{{"Theme","Dark"},{"language","French"}}
                );

                return Ok(session);
            }
            return Unauthorized();
        }


    }



}