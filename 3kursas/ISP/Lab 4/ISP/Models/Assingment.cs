using ISP.Backend;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ISP.Models
{
    public class Assingment
    {
        // The technology is just not there yet to parse a DateTime object
        [DatabaseField("data")]
        public string Date { get; set; }
        [DatabaseField("tema")] 
        public string Subject { get; set; }
        [DatabaseField("id")]
        public int Id { get; set; }
        [DatabaseField("fk_Modulis")]
        public string ModuleID { get; set; }

        public List<Marks> Marks { get; set; }

        public Assingment()
        {

        }
    }
}
