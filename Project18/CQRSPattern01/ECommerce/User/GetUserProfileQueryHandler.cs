using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ECommerce.Entities;
using MediatR;
using Microsoft.AspNetCore.Identity;

namespace ECommerce.User
{
    public class GetUserProfileQueryHandler : IRequestHandler<GetUserProfileQuery, UserProfileDto>
    {   
        private readonly UserManager<ApplicationUser> _userManager;

        public GetUserProfileQueryHandler(UserManager<ApplicationUser> userManager)
        {
            _userManager = userManager;   
        }
        public async Task<UserProfileDto> Handle(GetUserProfileQuery request, CancellationToken cancellationToken)
        {
            var user = await _userManager.FindByIdAsync(request.UserId);
            if(user == null)
                return null;
            
            return new UserProfileDto
            {
                FullName = user.FullName,
                Email = user.Email,
            };
        }
    }
}