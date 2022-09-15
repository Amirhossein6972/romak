using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Romak.Core.Model
{
    public class Person1
    {
        public long Id { get; set; }
        public string FullName { get; set; }
        public ICollection<Address1> Addresses { get; set; }
    }
}
