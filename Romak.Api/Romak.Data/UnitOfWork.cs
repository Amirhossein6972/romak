using Romak.Core;
using Romak.Core.Repositories;
using Romak.Data.Repositories;
using System.Threading.Tasks;

namespace Romak.Data
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly RomakDbContext _context;
        public UnitOfWork(RomakDbContext context)
        {
            _context = context;

        }

        IUserRepository _userRepository;
        IPersonRepository _personRepository;

        public IUserRepository userRepository => _userRepository ??= new UserRepository(_context);
        public IPersonRepository personRepository => _personRepository ??= new PersonRepository(_context);

        public int Complete()
        {
            return _context.SaveChanges();
        }

        public async Task<int> CompleteAsync()
        {
            return await _context.SaveChangesAsync();
        }
    }
}
