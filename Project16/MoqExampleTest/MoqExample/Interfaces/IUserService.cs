using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MoqExample.Interfaces
{
    public interface IUserService
    {
        public string GetUserName(int userID);
    }
}