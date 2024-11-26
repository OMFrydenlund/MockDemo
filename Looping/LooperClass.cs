using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Looping
{
    internal class LooperClass
    {
        public static void TerjeErKul()
        {
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Terje er kul.");
            }
        }

        public static void PrintEachLetter()
        {
            string sentence = "Who said it?";

            foreach (char c in sentence)
            {
                Console.WriteLine(c);
            }
        }

        public static void JustTenRounds()
        {
            int roundsCounter = 0;

            while (roundsCounter < 10)
            {
                roundsCounter++;
                Console.WriteLine($"This is round number {roundsCounter}.");
                Console.ReadLine();
            }
        }
    }
}
