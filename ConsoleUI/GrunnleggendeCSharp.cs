using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkoleKonsoll
{
    internal class GrunnleggendeCSharp
    {
        public static double BasicAddition(double a, double b)
        {
            double sum = a + b;
            return sum;

        }

        public static decimal AddDifferentNumberTypes()
        {
            int a = 4;
            decimal b = 3.4M;

            decimal sum = Convert.ToDecimal(a) + b;
            return sum;
        }

        public static bool EqualChecker(double a, double b)
        {
            if (a == b)
            {
                return true;
            }
            return false;
        }

        public static void PleaseDontPrintAnything()
        {
            Console.WriteLine("Denne metoden returnerer ingenting.");
        }

        public static void HelloHi(string name)
        {
            Console.WriteLine($"Hei og velkommen {name}!");
        }
    }
}
