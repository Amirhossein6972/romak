using Romak.Core.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Romak.Core.Repositories
{
    public interface IPersonRepository : IRepository<Person>
    {
        IEnumerable<Person> GetPersonListLambda();
        IEnumerable<Person> GetPersonListLinq();
        IEnumerable<Person> GetPersonListTSql();
    }
}
