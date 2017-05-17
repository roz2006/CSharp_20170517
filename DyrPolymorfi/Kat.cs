using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DyrPolymorfi
{
    class Kat: Dyr
    {
        public override void SigNoget()
        {
            Console.WriteLine("Jeg er en kat som hedder {0}", this.Navn);
        }
    }
}
