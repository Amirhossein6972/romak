using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Romak.Core.DTO
{
    public class UserDTO
    {
        public class UserLogin
        {
            public string UserName { get; set; }
            public string Password { get; set; }
        }

        public class UserLogged
        {
            public string UserName { get; set; }
            public string Role { get; set; }
        }
    }
}
