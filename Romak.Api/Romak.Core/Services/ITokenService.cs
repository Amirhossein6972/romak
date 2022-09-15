using Romak.Core.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Romak.Core.Services 
{
    public interface ITokenService
    {
        string BuildToken(string key, string issuer, UserDTO.UserLogged user);
        bool ValidateToken(string key, string issuer, string audience, string token);
    }
}
