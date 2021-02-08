using ISP.Backend;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ISP.Models
{
    public class Notice
    {
        [DatabaseField("fk_Irasas")]
        public int ID { get; set; }

        [DatabaseField("pavadinimas")]
        public string Name { get; set; }

        [DatabaseField("turinys")]
        public string Content { get; set; }

        [DatabaseField("fk_Vartotojas")]
        public string CreatorID { get; set; }

        // The technology is just not there yet to parse a DateTime object
        [DatabaseField("data")]
        public string Date { get; set; }

        public Notice()
        {

        }
    }
}
