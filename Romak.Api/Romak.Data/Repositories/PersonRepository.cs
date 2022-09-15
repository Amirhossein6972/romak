using Microsoft.EntityFrameworkCore;
using Romak.Core.Model;
using Romak.Core.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Romak.Data.Repositories
{
    public class PersonRepository : Repository<Person>, IPersonRepository
    {
        public PersonRepository(RomakDbContext repositoryContext) : base(repositoryContext) { }

        public RomakDbContext DBContext
        {
            get { return Context as RomakDbContext; }
        }

        public IEnumerable<Person> GetPersonListLambda()
        {
            return DBContext.People.Include(c => c.Addresses).AsEnumerable();
        }

        public IEnumerable<Person> GetPersonListLinq()
        {
            return (from person in DBContext.People
                    select new Person { Id = person.Id, FullName = person.FullName, Addresses = DBContext.Addresses.Where(c=>c.PersonId == person.Id).ToList() });
        }

        public IEnumerable<Person> GetPersonListTSql()
        {
            throw new NotImplementedException();
        }
    }
}
