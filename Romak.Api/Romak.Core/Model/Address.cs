using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Romak.Core.Model
{
    public class Address
    {
        public long  Id { get; set; }
        public long PersonId { get; set; }
        public string Street { get; set; }
        public string City { get; set; }

        public Person Person { get; set; }
    }
}
