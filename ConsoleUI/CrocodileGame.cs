using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI
{
    internal class CrocodileGame
    {
        public static void StartUp()
        {
            Console.WriteLine("Welcome to the Crocodile Game!" +
                "\nTo answer, simply type < > or =, or anything else to exit the game." +
                "\n\nPress any button to continue...");
            Console.ReadLine();
            Game();
        }

        static void Game()
        {
            //consider instantiating Random here with duplicate use, over calling a unique method
            Console.Clear();

            int roundsCounter = 1;
            int points = 0;

            int firstNumber = GenerateNumber();
            int secondNumber = GenerateNumber();

            Console.WriteLine($"{firstNumber} _ {secondNumber}");            
            Console.Write("Answer: ");
            string userInput = Console.ReadLine();

            //bool goodAnswer = CheckAnswer(firstNumber, secondNumber, userInput);

        }


        static bool CheckAnswer(int firstNumber, int secondNumber, string userInput)
        {
            if ((firstNumber < secondNumber) && userInput == "<")
            {
                return true;
            }
            else if ((firstNumber > secondNumber) && (userInput == ">"))
            {
                return true;
            }
            else if ((firstNumber < secondNumber) && userInput == "=")
            {
                return true;
            }
            return false;
            
        }

        static int GenerateNumber()
        {
            Random randomNumber = new Random();
            int number = randomNumber.Next(1, 11);
            return number;
        }
    }
}
