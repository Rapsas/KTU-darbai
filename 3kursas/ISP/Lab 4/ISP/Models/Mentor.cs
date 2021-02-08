using ISP.Backend;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ISP.Models
{
    public class Mentor
    {
        [DatabaseField("laikas")]
        public string Date { get; set; }

        [DatabaseField("id")]
        public int ID { get; set; }

        [DatabaseField("dalykas")]
        public string Name { get; set; }

        [DatabaseField("tema")]
        public string Subject { get; set; }

        [DatabaseField("vieta")]
        public string Location { get; set; }

        [DatabaseField("kurejas")]
        public bool IsCreator { get; set; }

        [DatabaseField("uzregistruotas")]
        public bool IsEnrolled { get; set; }

        [DatabaseField("fk_Vartotojas")]
        public string CreatorID { get; set; }

        [DatabaseField("vardas")]
        public string CreatorName { get; set; }

        [DatabaseField("pavarde")]
        public string CreatorSurname { get; set; }

        public Mentor()
        {

        }
    }
}
