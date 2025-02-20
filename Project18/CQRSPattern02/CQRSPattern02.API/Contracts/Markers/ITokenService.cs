using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CQRSPattern02.API.Identity;

namespace CQRSPattern02.API.Contracts.Markers
{
    public interface ITokenService
    {
        Task<string> GenerateTokenAsync(ApplicantUser user);
    }
}