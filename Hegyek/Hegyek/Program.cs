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

            Console.ReadKey();
        }
    }
}
