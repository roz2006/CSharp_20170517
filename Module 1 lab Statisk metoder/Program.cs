﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module_1_lab_Statisk_metoder
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(ArealBeregninger.BeregnArealFirkant(10,10));
            Console.WriteLine(ArealBeregninger.BeregnArealCirkel(10));

        }
    }

    class ArealBeregninger
    {
        public static double BeregnArealFirkant(double højde, double brede)
        {
            return højde * brede;
        }

        public static double BeregnArealCirkel(double radius)
        {
            return System.Math.Pow(radius,2)* System.Math.PI;
        }
    }
}
