using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MediatR;

namespace ECommerce.User
{
    public class GetUserProfileQuery:IRequest<UserProfileDto>
    {
        public string UserId {get; set;}
        public GetUserProfileQuery(string userId)
        {
            UserId = userId;   
        }   
    }
}