using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nedarvning
{
    class Program
    {
        static void Main(string[] args)
        {
            Terning t1 = new Terning();
            t1.Skriv();

            Terning t2 = new Terning(5);
            t2.Skriv();

            LudoTerning lt1 = new LudoTerning();
            lt1.Skriv();
            Console.WriteLine("Er det globus?:{0}", lt1.ErGlobus());
            Console.WriteLine("Er det stjerne?:{0}", lt1.ErStjerne());

            LudoTerning lt2 = new LudoTerning(5);
            lt2.Skriv();
            Console.WriteLine("Er det globus?:{0}", lt2.ErGlobus());
            Console.WriteLine("Er det stjerne?:{0}", lt2.ErStjerne());
        }
    }

    class Terning
    {
        private int _værdi;
        private static Random rnd;
        public int Værdi
        {
            get { Console.WriteLine("Værdi aflæses"); return _værdi; }
            set
            {
                if (value < 1 || value > 6)
                    value = 1;
                _værdi = value;
                Console.WriteLine("Værdi tildeles");
            }
        }

        static Terning()
        {
            rnd = new Random();
        }
        public Terning()
        {
            int n = this.Ryst();
            Console.WriteLine("generated number er: {0}", n);
            this.Værdi= n;
        }

        public Terning(int værdi)
        {
            this.Værdi = værdi;
        }
        public int Ryst()
        {
            return rnd.Next(1, 100);
        }

        public void Skriv()
        {
            Console.WriteLine(this.Værdi.ToString());
        }


    }
}
