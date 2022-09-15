using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Romak.Core.Model
{
    public class Role
    {
        public long Id { get; set; }
        public string Name { get; set; }

        public ICollection<User> Users { get; set; }
    }
}
