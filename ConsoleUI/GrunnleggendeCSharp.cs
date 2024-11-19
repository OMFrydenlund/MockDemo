using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkoleKonsoll
{
    internal class GrunnleggendeCSharp
    {
        //account for parameters/no parameters along with the type when calling in Main()

        //EXAMPLE:
        // Console.WriteLine("Hei, hva heter du?");
        // string userInput = Console.ReadLine();
        // string response = GrunnleggendeCSharp.HelloHi(userInput);
        public static void HelloHi(string name)
        {
            Console.WriteLine($"Hei og velkommen {name}!");
        }

        public static decimal AddDifferentNumberTypes()
        {
            int a = 4;
            decimal b = 3.4M;

            decimal sum = Convert.ToDecimal(a) + b;
            return sum;
        }

        public static double BasicAddition(double a, double b)
        {
            double sum = a + b;
            return sum;
        }

        public static void PleaseDontPrintAnything()
        {
            Console.WriteLine("Denne metoden returnerer ingenting.");
        }

        public static bool EqualChecker(double a, double b)
        {
            if (a == b)
            {
                return true;
            }
            return false;
        }

        public static double SumOrProduct(double a, double b)
        {
            if (a != b)
            {
                return a + b;
            }
            else
            {
                return a * b;
            }
        }

        public static bool ThirtyOrNot(int a, int b)
        {
            if ((a + b) == 30 || (a == 30) || (b == 30))
            {
                return true;
            }
            return false;
        }

    }
}
