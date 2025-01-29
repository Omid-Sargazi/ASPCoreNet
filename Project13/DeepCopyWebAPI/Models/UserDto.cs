using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DeepCopyWebAPI.Models
{
    public class UserDto
    {
        public string Name {get; set;}
        public string Email {get; set;}
        public ProfileDto Profile {get; set;}

        public UserDto DeepCopy()
        {
            return new UserDto
            {
                Name = this.Name,
                Email = this.Email,
                Profile = new ProfileDto {Address = this.Profile.Address}
            };
        }
    }
}