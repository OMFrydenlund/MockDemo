using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI
{
    internal class CrocodileGame
    {
        private static int _pointCounter;
        private static int _roundCounter;
        private static string _userInput;

        public static void Game()
        {
            
            Console.Clear();
            Random randomNum = new Random();
            _roundCounter++;

            int firstNum = randomNum.Next(1, 11);
            int secondNum = randomNum.Next(1, 11);

            Console.WriteLine($"Round: {_roundCounter}" +
                $"\nPoints: {_pointCounter}");
            Console.Write($"\n\nIs it <, > or =?\n{firstNum} _ {secondNum}\n");
            _userInput = Console.ReadLine();

            if (_userInput != "<" && _userInput != ">" && _userInput != "=")
            {
                Console.WriteLine("Exiting game...");
                Console.ReadLine();
                Environment.Exit(0);
            }
            RespondToCheck(firstNum, secondNum);
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
        
        static void RespondToCheck(int leftNumber, int rightNumber)
        {
            string correctAnswer = AnswerCheck(leftNumber, rightNumber);
            if (_userInput == correctAnswer)
            {
                _pointCounter++;
                Console.WriteLine($"That's correct! The answer is {correctAnswer}.");
                Console.ReadLine();
                Game();
            }
            else if (_userInput != correctAnswer)
            {
                _pointCounter--;
                Console.WriteLine($"Unfortunately it was not {_userInput}, but {correctAnswer}.");
                Console.ReadLine();
                Game();
            }
        }
    }
}
