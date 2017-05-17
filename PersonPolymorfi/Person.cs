using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonPolymorfi
{
    class Person
    {
        public string ForNanv { get; set; }
        public string EfterNavn { get; set; }

        public virtual void Skriv()
        {
            Console.WriteLine("Jer er en person som hedder {0}.", ForNanv+' '+EfterNavn);
        }
    }
}
