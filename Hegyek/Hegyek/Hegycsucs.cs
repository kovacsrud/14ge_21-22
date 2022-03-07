using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hegyek
{
    public class Hegycsucs
    {
        public string HegycsucsNeve { get; set; }
        public string Hegyseg { get; set; }
        public int Magassag { get; set; }

        public Hegycsucs(string sor)
        {
            var adatok = sor.Split(';');
            HegycsucsNeve = adatok[0];
            Hegyseg = adatok[1];
            Magassag = Convert.ToInt32(adatok[2]);
        }
    }
}
