using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace APIAuthenticationTest.API.Contracts.Abstracts
{
    public sealed class MetaData
    {
         public Guid? UserId {get; set;}
        public string? UserName {get; set;}
        public List<string> RoleNames {get; set;}   
    }
}