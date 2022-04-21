using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atletika_14ge
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Versenyzo> versenyzok = new List<Versenyzo>();
            try
            {
                var sorok = File.ReadAllLines("atletikaVB2017.csv", Encoding.Default);
                for (int i = 0; i < sorok.Length; i++) 
                {
                    versenyzok.Add(new Versenyzo(sorok[i]));
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);                
            }

            Console.WriteLine($"Elemek száma:{versenyzok.Count}");

            var versenySzamDb = versenyzok.ToLookup(x=>x.VersenySzam).Count;
            //foreach (var i in versenySzamDb)
            //{
            //    Console.WriteLine($"{i.Key}");
            //}


            Console.WriteLine($"Érmek száma:{versenyzok.Count}, Versenyszámok:{versenySzamDb} db.");
            var amerika = versenyzok.FindAll(x => x.Nemzet == "Egyesült Államok");
            var usaArany = amerika.FindAll(x => x.Erem == 1).Count;
            Console.WriteLine($"Usa aranyak százaléka:{(double)usaArany/(double)amerika.Count*100:0.0}");

            var csucsnok = versenyzok.FindAll(x => x.Nem == "N" && x.Csucs!="");

            

            try
            {
                FileStream fajl = new FileStream("noi_csucsok.txt", FileMode.Create);
                StreamWriter writer = new StreamWriter(fajl, Encoding.Default);

                foreach (var i in csucsnok)
                {
                    writer.WriteLine($"{i.Nev}{"\t"}{i.VersenySzam}{"\t"}{i.Nemzet}");
                }
                writer.Close();
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
            }

            Console.ReadKey();
        }
    }
}
