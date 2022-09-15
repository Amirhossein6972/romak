using Microsoft.EntityFrameworkCore;
using Romak.Core.DTO;
using Romak.Core.Model;
using Romak.Core.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Romak.Data.Repositories
{
    public class UserRepository : Repository<User>, IUserRepository
    {
        public UserRepository(RomakDbContext repositoryContext) : base(repositoryContext) { }

        public RomakDbContext DBContext
        {
            get { return Context as RomakDbContext; }
        }

        public User GetUser(string username, string password)
        {
            return DBContext.Users.Where(c => c.Name == username && c.Password == password).Include(c=>c.Role).FirstOrDefault();
        }
    }
}
