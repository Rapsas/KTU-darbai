using ISP.Backend;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ISP.Models
{
    public class Module
    {
        [DatabaseField("pavadinimas")]
        public string Name { get; set; }
        [DatabaseField("kodas")]
        public string ID { get; set; }
        [DatabaseField("reikalavimai")]
        public string Requirements { get; set; }
        [DatabaseField("aprasas")]
        public string Description { get; set; }

        public List<Assingment> Assingments { get; set; }
        public List<Lecture> Lectures { get; set; }
        public Module()
        {

        }
    }
}
