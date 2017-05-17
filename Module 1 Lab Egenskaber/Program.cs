using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module_1_Lab_Egenskaber
{
    class Program
    {
        static void Main(string[] args)
        {
            Trekant t1 = new Trekant();
            Console.WriteLine("Default constructor trekant har grundlinje som {0} og højde {1}", t1.Grundlinje.ToString(),t1.Højde.ToString());
            Console.WriteLine("Areal af trekant er {0}",t1.Areal.ToString());

            Trekant t2 = new Trekant(15, 25);
            Console.WriteLine("Default constructor trekant har grundlinje som {0} og højde {1}", t2.Grundlinje.ToString(), t2.Højde.ToString());
            Console.WriteLine("Kalder metod for at berege areal af trekant");
            Console.WriteLine("Areal af min først trekant er {0}",t2.BeregnAreal().ToString());
        }
    }

    class Trekant
    {
        private const double moms= 0.25;
        public int Grundlinje { get; private set; }
        public int Højde { get; private set; }

        private double areal;

        public double Areal
        {
            get { return areal = Grundlinje * Højde * 0.5; }
        }

        public Trekant()
        {
            Grundlinje = 10;
            Højde = 20;
        }

        public Trekant(int grundlinje, int højde)
        {
            Grundlinje = grundlinje;
            Højde = højde;
        }

        public double BeregnAreal()
        {
            return Grundlinje * Højde * 0.5;
        }
    }
}
