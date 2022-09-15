using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Romak.Core.Services
{
    public interface IUserService
    {
        Task<string> Login(string username,string password);
    }
}
