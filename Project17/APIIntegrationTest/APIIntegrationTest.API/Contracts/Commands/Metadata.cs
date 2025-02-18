using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace APIIntegrationTest.API.Contracts.Commands
{
    public sealed class Metadata
    {
    public Guid? UserId {get; set;}
    public string? UserName {get; set;}
    public List<string> RoleNames {get; set;}
    }


}