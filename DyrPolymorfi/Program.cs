using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DyrPolymorfi
{
    class Program
    {
        static void Main(string[] args)
        {
            Dyr[] dyrne = new Dyr[20];

            for (int i = 0; i < 20; i++)
            {
                dyrne[i] = Dyr.TilFældigtDyr();
            }

            foreach (var item in dyrne)
            {
                item.SigNoget();
            }
        }
    }
}
