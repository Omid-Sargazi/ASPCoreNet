using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MoqExample.Interfaces;

namespace MoqExample.Implements
{
    public class UserService : IUserService
    {
        public string GetUserName(int userID)
        {
            throw new NotImplementedException();
        }
    }
}