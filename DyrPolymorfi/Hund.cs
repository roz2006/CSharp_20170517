using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DyrPolymorfi
{
    class Hund:Dyr
    {
        public override void SigNoget()
        {
            Console.WriteLine("Jeg er en hund som hedder {0}", this.Navn);
        }

    }
}
