using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfeszek
{
    class Program
    {
        static void Main(string[] args)
        {
            List<ISikidom> sikidomok = new List<ISikidom>();

            Kor k1 = new Kor(23);
            //Console.WriteLine($"Kerület:{k1.Kerulet()},Terület:{k1.Terulet()}");

            Teglalap t1 = new Teglalap(11, 23);
            //Console.WriteLine($"Kerület:{t1.Kerulet()},Terület:{t1.Terulet()}");

            Kor k2 = new Kor(39);
            Kor k3 = new Kor(46);
            Kor k4 = new Kor(71);

            Teglalap t2 = new Teglalap(9, 21);
            Teglalap t3 = new Teglalap(36, 48);
            Teglalap t4 = new Teglalap(57, 51);

            sikidomok.Add(k1);
            sikidomok.Add(k2);
            sikidomok.Add(k3);
            sikidomok.Add(k4);

            sikidomok.Add(t1);
            sikidomok.Add(t2);
            sikidomok.Add(t3);
            sikidomok.Add(t4);

            //Listázzunk!
            foreach (var i in sikidomok)
            {
                Console.WriteLine($"Kerület:{i.Kerulet()},Terület:{i.Terulet()}");
            }

            var osszKerulet = sikidomok.Sum(x=>x.Kerulet());
            Console.WriteLine($"Az összes kerület:{osszKerulet:0.00}");

            var osszTerulet = sikidomok.Sum(x => x.Terulet());
            Console.WriteLine($"Az összes terület:{osszTerulet:0.00}");

            foreach (var i in sikidomok)
            {
                if (i.GetType()==typeof(Kor))
                {
                    
                    Kor kor = (Kor)i;
                    Console.WriteLine($"{kor.Sugar}");
                    
                } else
                {
                    Teglalap teglalap = (Teglalap)i;
                    Console.WriteLine($"{teglalap.Aoldal},{teglalap.Boldal}");
                }
            }

            var korAtlagTerulet = sikidomok.FindAll(x=>x.GetType()==typeof(Kor)).Average(x=>x.Terulet());
            Console.WriteLine(korAtlagTerulet);
            //téglalapok összkerülete

            var teglalapOsszKerulet = sikidomok.FindAll(x => x.GetType() == typeof(Teglalap)).Sum(x=>x.Kerulet());
            Console.WriteLine(teglalapOsszKerulet);
            Console.ReadKey();
        }
    }
}
