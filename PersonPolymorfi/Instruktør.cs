using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonPolymorfi
{
    class Instruktør: Person
    {
        public int NøgleId { get; set; }

        public override void Skriv()
        {
            Console.WriteLine("Jeg er en instruktør som hedder {0} or har nøgleID some {1}",this.ForNanv+' '+this.EfterNavn,this.NøgleId);
        }
    }
}
