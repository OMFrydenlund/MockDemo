using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkoleKonsoll
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            bool equalCheckValue = GrunnleggendeCSharp.ErDeLikeTall(14.3, 14.5);

            Console.WriteLine($"The equal checker says: {equalCheckValue}");

            Console.ReadLine();
        }

    }
}
