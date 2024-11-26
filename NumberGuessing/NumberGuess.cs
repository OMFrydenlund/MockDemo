using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumberGuessing
{
    internal class NumberGuess
    {
        private static int CorrectNumber;
        private static int UserGuess;

        public static void GuessTheNumber()
        {
            Console.Clear();
            Random newRandomInstance = new Random();
            CorrectNumber = newRandomInstance.Next(1, 100);

            bool isNumber = false;
            int validatedNumber = 0;

            while (isNumber == false)
            {
                //nitpick clearing console to ask questions in a loop
                Console.Write("What's the number: ");
                isNumber = int.TryParse(Console.ReadLine(), out UserGuess);
                validatedNumber = ValidateNumber(UserGuess);
            }


            LowOrHighCheck(validatedNumber);
            PlayAagain();

        }

        static int ValidateNumber(int userGuess)
        {
            if (userGuess < 0 || userGuess > 100)
            {
                Console.WriteLine("Not a valid number. Pick one between 1 and 100.");
                int.TryParse(Console.ReadLine(), out userGuess);
                ValidateNumber(userGuess);
            }

            return userGuess;
        }

        static void LowOrHighCheck(int validatedNumber)
        {
            int newGuess;
            if (validatedNumber < CorrectNumber)
            {
                Console.WriteLine("GO HIGHER");
                int.TryParse(Console.ReadLine(), out newGuess);
                LowOrHighCheck(newGuess);
            }
            else if (validatedNumber > CorrectNumber)
            {
                Console.WriteLine("go lower");
                int.TryParse(Console.ReadLine(), out newGuess);
                LowOrHighCheck(newGuess);
            }
            else
            {
                Console.WriteLine($"Correct! The number was indeed {CorrectNumber}.");
                Console.ReadLine();
            }
        }

        static void PlayAagain()
        {
            Console.Clear();
            Console.WriteLine($"Would you like to play again?\n1) Yes\n2) No");
            int userInput = int.Parse(Console.ReadLine());

            switch (userInput)
            {
                case 1:
                    GuessTheNumber();
                    break;
                case 2:
                    Environment.Exit(0);
                    break;
                default:
                    Console.WriteLine("Not a valid choice");
                    break;
            }
        }
    }
}
