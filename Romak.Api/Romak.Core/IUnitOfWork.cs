using Romak.Core.Repositories;
using System.Threading.Tasks;

namespace Romak.Core
{
    public interface IUnitOfWork
    {
        IUserRepository userRepository { get; }
        IPersonRepository personRepository { get; }

        int Complete();

        Task<int> CompleteAsync();
    }
}
