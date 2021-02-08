using ISP.Backend;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ISP.Models
{
    public class Participant
    {
        [DatabaseField("fk_Modulis")]
        public string Module { get; set; }
        [DatabaseField("fk_Vartotojas")]
        public string Atendee { get; set; }

        public Participant()
        {

        }
    }
}
