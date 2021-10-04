using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Osztalyok
{
    public abstract class Hos
    {
       

        public int Eletero { get;  }
        public int Sebzes { get;  }
        public string Nev { get; }


        public Hos(int eletero, int sebzes, string nev)
        {
            Eletero = eletero;
            Sebzes = sebzes;
            Nev = nev;
        }

        public abstract void Tamad();

        public abstract void Vedekezik();

        public virtual void Allapot()
        {
            Console.WriteLine($"Hős neve:{Nev},életerő:{Eletero}");
        }






    }
}
