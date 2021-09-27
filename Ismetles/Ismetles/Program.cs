using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ismetles
{
    class Program
    {
        static void Main(string[] args)
        {
            //változók
            //egész számok
            int szamA = 10;
            int szamB = 1123;

            Console.WriteLine(Int32.MinValue);
            Console.WriteLine(Int32.MaxValue);

            //lebegőpontos
            float lebego1 = 13.6678f;
            double lebego2 = 12.6656565665;
            decimal lebego3 = 456.453437676776576m;

            //logikai
            bool igaze = true;

            //string
            string szoveg = "Valami szöveg";

            //karakter
            char karakter = 'h';

            var ertek = "Izé";

            //tömb
            int[] szamok = { 12, 45,67,899 };
            var szamok2 = new int[5];

            Random rand = new Random();

            for (int i = 0; i < szamok2.Length; i++)
            {
                szamok2[i] = rand.Next(10, 101);
            }

            for (int i = 0; i < szamok2.Length; i++)
            {
                Console.Write(szamok2[i] + " ");
            }

            Console.WriteLine();
            Console.WriteLine(szamok2.Sum());
            Console.WriteLine(szamok2.Min());
            Console.WriteLine(szamok2.Max());

            //Listák
            List<int> szamlista = new List<int>();

            szamlista.Add(15);
            szamlista.Add(233);
            szamlista.Add(788);

            Console.WriteLine($"A lista elemszáma:{szamlista.Count}");

            szamlista.RemoveAt(0);
            szamlista.Remove(233);
            

            Console.WriteLine($"A lista elemszáma:{szamlista.Count}");




            Console.ReadKey();
        }
    }
}
