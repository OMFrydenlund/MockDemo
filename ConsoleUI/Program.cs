using ConsoleUI;
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
            // calling some methods will require Console.ReadLine here to function properly
            NumberGuess.GuessTheNumber();
            Console.ReadLine();
        }

    }
}
