using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI
{
    internal class NumberGuess
    {
        private static int CorrectNumber;
        private static int UserGuess;

        public static void GuessTheNumber()
        {            
            Random newRandomInstance = new Random();
            CorrectNumber = newRandomInstance.Next(1, 100);
            Console.Write("What's the number: ");

            int.TryParse(Console.ReadLine(), out UserGuess);
            int validatedNumber = ValidateNumber(UserGuess);

            LowOrHighCheck(validatedNumber);

        }

        static int ValidateNumber(int userGuess)
        {
            if (userGuess < 0 || userGuess > 100)
            {
                Console.WriteLine("Not a valid number. Guess again...");
                int.TryParse(Console.ReadLine(), out userGuess);
                ValidateNumber(userGuess);
            }
            return userGuess;
        }

        static void LowOrHighCheck(int validatedNumber)
        {
            if (validatedNumber < CorrectNumber)
            {
                Console.WriteLine("GO HIGHER");
            }
            else if (validatedNumber > CorrectNumber)
            {
                Console.WriteLine("go lower");
            }
            else
            {
                Console.WriteLine($"Correct! The number was indeed {CorrectNumber}." +
                    $"\nWould you like to play again?\n1) Yes\n2) No");
                //implement code for replayability
            }
        }
    }
}
