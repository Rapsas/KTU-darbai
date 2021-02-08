using ISP.Backend;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ISP.Models
{
    public class Message
    {
        [DatabaseField("data")]
        public string Date { get; set; }

        [DatabaseField("fk_Irasas")]
        public int ID { get; set; }

        [DatabaseField("pavadinimas")]
        public string Name { get; set; }

        [DatabaseField("turinys")]
        public string Content { get; set; }

        [DatabaseField("fk_Vartotojas")]
        public string CreatorID { get; set; }

        [DatabaseField("vardas")]
        public string CreatorName { get; set; }

        [DatabaseField("pavarde")]
        public string CreatorSurname { get; set; }

        public Message()
        {

        }
    }
}
