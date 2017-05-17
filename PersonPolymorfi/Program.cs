using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonPolymorfi
{
    class Program
    {
        static void Main(string[] args)
        {
            Person[] lst = new Person[3];
            lst[0] = new Person() { ForNanv = "Jens", EfterNavn = "Jensens" };
            lst[1] = new Elev() { ForNanv = "Andrea", EfterNavn = "Andersen", KlassLokale = "8.2.16" };
            lst[2] = new Instruktør() { ForNanv = "Tom", EfterNavn = "Thomasen", NøgleId = 13 };

            foreach (var item in lst)
            {
                item.Skriv();
            }
        }
    }
}
