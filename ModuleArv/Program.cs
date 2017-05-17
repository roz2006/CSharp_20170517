using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModuleArv
{
    class Program
    {
        static void Main(string[] args)
        {
            Person p1 = new Person() { ForNavn = "Flemming", EfterNavn = "Jensen" };
            Console.WriteLine(p1.FuldtNavn(p1.ForNavn, p1.EfterNavn));

            Elev e1 = new Elev("Thomas", "Andersen", "8.2.16");
            Console.WriteLine(e1.FuldtNavn(e1.ForNavn,e1.EfterNavn));
        }
    }

    class Person
    {
        public string ForNavn { get; set; }
        public string EfterNavn { get; set; }

        public string FuldtNavn(string fornavn, string efternavn)
        {
            return fornavn + ' ' + efternavn;
        }

        public Person(string fn, string ef)
        {
            this.ForNavn = fn;
            this.EfterNavn = ef;
        }

        public Person()
        {

        }

    }

    class Elev : Person
    {
        public string KlasseLokale { get; set; }

        public Elev(string fornavn, string efternavn, string locale) : base(fornavn, efternavn)
        {
            this.KlasseLokale = locale;
        }

    }

    class Instruktør : Person
    {
        public int NøgleId { get; set; }
    }
}
