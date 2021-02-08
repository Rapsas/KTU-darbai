using ISP.Backend;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ISP.Models
{
    public class User
    {
        [DatabaseField("asmens_kodas")]
        public string PersonalCode { get; set; }

        [DatabaseField("vardas")]
        public string Name { get; set; }

        [DatabaseField("pavarde")]
        public string Surname { get; set; }

        [DatabaseField("slaptazodis")]
        public string Password { get; set; }

        [DatabaseField("vartotojo_tipas")]
        public int Type { get; set; }

        public User()
        {

        }
    }
}
