using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hegyek
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Hegycsucs> hegycsucsok = new List<Hegycsucs>();
            try
            {
                var sorok = File.ReadAllLines("hegyek.txt",Encoding.Default);

                for (int i = 0; i < sorok.Length; i++)
                {
                    hegycsucsok.Add(new Hegycsucs(sorok[i]));
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine(ex.StackTrace);
            }

            Console.WriteLine($"A fájl sorainak száma:{hegycsucsok.Count}");

            var atlagMagassag = hegycsucsok.Average(x=>x.Magassag);
            Console.WriteLine($"A hegycsúcsok átlag magassága:{atlagMagassag:0.0}");

            var legMagasabb = hegycsucsok.Find(x => x.Magassag == hegycsucsok.Max(y => y.Magassag));
            Console.WriteLine($"{legMagasabb.HegycsucsNeve},{legMagasabb.Magassag}");

            var beMagassag = Convert.ToInt32(Console.ReadLine());

            var vanEMagasabb = hegycsucsok.FindAll(x => x.Hegyseg == "Börzsöny" && x.Magassag > beMagassag);

            if (vanEMagasabb.Count > 0)
            {
                Console.WriteLine($"A börzsönyben van {beMagassag} m-nél magasabb csúcs!");
            } else
            {
                Console.WriteLine($"A börzsönyben nincs {beMagassag} m-nél magasabb csúcs!");
            }

            if (hegycsucsok.Any(x=>x.Hegyseg=="Börzsöny" && x.Magassag>beMagassag))
            {
                Console.WriteLine($"A börzsönyben van {beMagassag} m-nél magasabb csúcs!");
            } else
            {
                Console.WriteLine($"A börzsönyben nincs {beMagassag} m-nél magasabb csúcs!");
            }

            var magasabb3000 = hegycsucsok.FindAll(x => x.Magassag * 3.28 > 3000).Count;
            Console.WriteLine($"3000 lábnál magasabb csúcsok száma:{magasabb3000}");

            var stat = hegycsucsok.ToLookup(x=>x.Hegyseg);

            foreach (var i in stat)
            {
                Console.WriteLine($"{i.Key} - {i.Count()} db átlagos magasság:{i.Average(x=>x.Magassag)} m");
            }

            var bukkvidek = hegycsucsok.FindAll(x => x.Hegyseg.ToLower() == "Bükk-vidék".ToLower());

            try
            {
                FileStream fajl = new FileStream("bukk-videk.txt",FileMode.Create);
                StreamWriter writer = new StreamWriter(fajl, Encoding.UTF8);
                foreach (var i in bukkvidek)
                {
                    writer.WriteLine($"{i.HegycsucsNeve};{i.Hegyseg};{i.Magassag}");
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
