using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CQRSPattern02.API.Contracts.Markers;
using CQRSPattern02.API.Identity;

namespace CQRSPattern02.API.Contracts
{
    public class TokenService : ITokenService
    {
        public Task<string> GenerateTokenAsync(ApplicantUser user)
        {
            var token = $"{user.Id} - {DateTime.UtcNow.Ticks}";
            return Task.FromResult(token);
        }
    }
}