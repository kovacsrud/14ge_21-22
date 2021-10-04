using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Osztalyok
{
    class Program
    {
        static void Main(string[] args)
        {
            //példányosítás

            Varazslo varazslo = new Varazslo(45, 100, 12, "Merlin");
            Varazslo varazslo2 = new Varazslo(40, 100, 22, "Merlin2");

            varazslo.Allapot();
            varazslo2.Allapot();



            Console.ReadKey();
        }
    }
}
