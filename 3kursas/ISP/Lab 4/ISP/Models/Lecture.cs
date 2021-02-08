using ISP.Backend;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ISP.Models
{
    public class Lecture
    {
        [DatabaseField("tema")]
        public string Subject { get; set; }
        [DatabaseField("data")]
        public string Date { get; set; }
        [DatabaseField("id")]
        public int Id { get; set; }
        [DatabaseField("fk_Modulis")]
        public string ModuleID { get; set; }
        public List<Attendence> Attendences { get; set; }
    }
}
