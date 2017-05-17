using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonPolymorfi
{
    class Elev: Person
    {
        public string KlassLokale { get; set; }

        public override void Skriv()
        {
            Console.WriteLine("Jeg er en elev som hedder {0} or har klasselocale i {1}.", this.ForNanv+' '+this.EfterNavn, this.KlassLokale);
        }
    }
}
