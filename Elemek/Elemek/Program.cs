using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Elemek
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Elem> elemek = new List<Elem>();
            try
            {
                var sorok = File.ReadAllLines("felfedezesek.csv", Encoding.Default);
                for (int i = 1; i < sorok.Length; i++)
                {
                    elemek.Add(new Elem(sorok[i]));
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);                
            }

            Console.WriteLine($"Az adatok száma:{elemek.Count}");

            var okori = elemek.FindAll(x=>x.Ev.ToLower()=="ókor".ToLower()).Count;
            Console.WriteLine($"Ókorban felfedezett elemek:{okori}");

            //Alternatív megoldás
            //var okori = elemek.FindAll(x => x.Ev == "Ókor");
            //Console.WriteLine($"Ókorban felfedezett elemek:{okori.Count}");

            Console.Write("Adjon meg egy vegyjelet:");
            var vegyjel = Console.ReadLine();
            while (vegyjel.Length<1 || vegyjel.Length>2)
            {
                Console.Write("Adjon meg egy vegyjelet:");
                vegyjel = Console.ReadLine();

            }

            var keresettVegyjel = elemek.Find(x => x.Vegyjel.ToLower() == vegyjel.ToLower());

            if (keresettVegyjel!=null)
            {
                Console.WriteLine($"{keresettVegyjel.Nev}");
            } else
            {
                Console.WriteLine("Nincs ilyen elem az adatforrásban!");
            }

            var okorUtan = elemek.FindAll(x => x.Ev != "Ókor");

            var maxKulonbseg = 0;

            for (int i = 1; i < okorUtan.Count; i++)
            {
                var kulonbseg = Math.Abs(Convert.ToInt32(okorUtan[i - 1].Ev) - Convert.ToInt32(okorUtan[i].Ev));
                if (kulonbseg>maxKulonbseg)
                {
                    maxKulonbseg = kulonbseg;
                }
            }

            Console.WriteLine($"A legtöbb év két elem felfedezése között:{maxKulonbseg}");


            Console.ReadKey();
        }
    }
}
