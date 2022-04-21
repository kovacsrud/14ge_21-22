using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atletika_14ge
{
    public class Versenyzo
    {
        public string VersenySzam { get; set; }
        public string Nem { get; set; }
        public string Nemzet { get; set; }
        public string Nev { get; set; }
        public string Eredmeny { get; set; }
        public string Csucs { get; set; }
        public int Erem { get; set; }

        public Versenyzo(string sor)
        {
            var adatok = sor.Split(';');
            VersenySzam = adatok[0];
            Nem = adatok[1];
            Nemzet = adatok[2];
            Nev = adatok[3];
            Eredmeny = adatok[4];
            Csucs = adatok[5];
            Erem = Convert.ToInt32(adatok[6]);
        }

    }
}
