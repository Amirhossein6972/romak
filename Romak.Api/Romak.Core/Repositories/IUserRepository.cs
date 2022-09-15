using Romak.Core.DTO;
using Romak.Core.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Romak.Core.Repositories
{
    public interface IUserRepository : IRepository<User>
    {
        User GetUser(string username,string password);
    }
}
