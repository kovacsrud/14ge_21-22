using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Elemek
{
    public class Elem
    {
        public string Ev { get; set; }
        public string Nev { get; set; }
        public string Vegyjel { get; set; }
        public int Rendszam { get; set; }
        public string Felfedezo { get; set; }

        public Elem(string sor)
        {
            var adatok = sor.Split(';');
            Ev = adatok[0];
            Nev = adatok[1];
            Vegyjel = adatok[2];
            Rendszam = Convert.ToInt32(adatok[3]);
            Felfedezo = adatok[4];
        }
    }
}
