using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfeszek
{
    public class Teglalap:ISikidom
    {
        

        public double Aoldal { get; set; }
        public double Boldal { get; set; }

        public Teglalap(double aoldal, double boldal)
        {
            Aoldal = aoldal;
            Boldal = boldal;
        }

        public double Kerulet()
        {
            return (Aoldal + Boldal) * 2;
        }

        public double Terulet()
        {
            return Aoldal * Boldal;
        }
    }
}
