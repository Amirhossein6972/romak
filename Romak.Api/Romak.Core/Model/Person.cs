using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Romak.Core.Model
{
    public class Person
    {
        public long Id { get; set; }
        public string FullName { get; set; }
        public ICollection<Address> Addresses { get; set; }
    }
}
