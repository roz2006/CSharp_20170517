using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DyrPolymorfi
{
    class Dyr
    {
        public string Navn { get; set; }

        public virtual void SigNoget()
        {
            Console.WriteLine("Jeg er et dyr or hedder {0}", Navn);
        }
        static System.Random rnd = new Random();
        public static Dyr TilFældigtDyr()
        {
            string filename = @"C:\temp\dyrenavne.txt";
            string[] navne = System.IO.File.ReadAllLines(filename);
           // Random rnd = new Random();  
            int number = rnd.Next(0, navne.Length);
            
            if (number%2 == 0)
                return new Hund() { Navn = navne[number]};
            else
                return new Kat() { Navn = navne[number] };

        }
    }
}
