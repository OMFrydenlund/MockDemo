using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI
{
    internal class CrocodileGame
    {
        private static Random randomNum = new Random();
        public static void Game()
        {
            int points = 0;
            int rounds = 0;

            int firstNum = GetNumber();
            int secondNum = GetNumber();

            Console.Write($"Is it <, > or =?\n{firstNum} _ {secondNum}\n");
            string userInput = Console.ReadLine();

            string correctAnswer = AnswerCheck(firstNum, secondNum);
            if (userInput == correctAnswer)
            {
                Console.WriteLine($"That's correct! The answer is {correctAnswer}.");
            }
            
        }

        public static int GetNumber()
        {           
            int a = randomNum.Next(1, 11);
            return a;
        }

        static string AnswerCheck(int numA, int numB)
        {
            if (numA > numB)
            {
                return ">";
            }
            else if (numA < numB)
            {
                return "<";
            }
            else if (numA == numB)
            {
                return "=";
            }
            else
            {
                return "exitPrint";
            }
        }
    }
}
