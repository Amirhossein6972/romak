using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Linq.Expressions;

namespace Romak.Core.Repositories
{
    public interface IRepository<T> where T : class
    {
        T Get(int id);

        ValueTask<T> GetAsync(int id);
        ValueTask<T> GetAsync(long id);

        IEnumerable<T> GetAll();

        Task<List<T>> GetAllAsync();

        IEnumerable<T> Find(Expression<Func<T, bool>> predicate);

        Task<IEnumerable<T>> FindAsync(Expression<Func<T, bool>> predicate);


        T SingleOrDefault(Expression<Func<T, bool>> predicate);

        Task<T> SingleOrDefaultAsync(Expression<Func<T, bool>> predicate);

        void Add(T entity);

        Task AddAsync(T entity);
        void AddRange(IEnumerable<T> entities);

        Task AddRangeAsync(IEnumerable<T> entities);

        void Remove(T entity);

        void RemoveRange(IEnumerable<T> entities);

        void Update(T entity);
    }
}
