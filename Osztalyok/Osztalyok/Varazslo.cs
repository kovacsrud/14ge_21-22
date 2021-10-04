using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Osztalyok
{
    public class Varazslo : Hos
    {

        public int Varazsero { get; }
        public Varazslo(int varazsero, int eletero, int sebzes, string nev):base(eletero,sebzes,nev)
        {
            Varazsero = varazsero;
        }

       
        public override void Tamad()
        {
            Console.WriteLine("A varázsló támad!");
        }

        public override void Vedekezik()
        {
            Console.WriteLine("A varázsló védekezik!");
        }

        public void Varazsol()
        {
            Console.WriteLine("A varázsló varázsol");
        }

        public override void Allapot()
        {
            base.Allapot();
            
            Console.WriteLine($"Varázserő:{Varazsero}");
        }


    }
}
