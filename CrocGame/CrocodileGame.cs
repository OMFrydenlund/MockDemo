using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrocGame
{
    internal class CrocodileGame
    {
        public static int PointCounter { get; private set; }
        public static int RoundCounter { get; private set; }
        public static string UserInput { get; private set; }

        public static void Game()
        {

            Console.Clear();
            Random randomNum = new Random();
            RoundCounter++;

            int firstNum = randomNum.Next(1, 11);
            int secondNum = randomNum.Next(1, 11);

            Console.WriteLine($"Round: {RoundCounter}" +
                $"\nPoints: {PointCounter}");
            Console.Write($"\n\nIs it <, > or =?\n{firstNum} _ {secondNum}\n");
            UserInput = Console.ReadLine();

            if (UserInput != "<" && UserInput != ">" && UserInput != "=")
            {
                Console.WriteLine("Exiting game...");
                Console.ReadLine();
                Environment.Exit(0);
            }
            RespondToCheck(firstNum, secondNum);
        }
        static void RespondToCheck(int leftNumber, int rightNumber)
        {
            string correctAnswer = AnswerCheck(leftNumber, rightNumber);
            if (UserInput == correctAnswer)
            {
                PointCounter++;
                Console.WriteLine($"That's correct! The answer is {correctAnswer}.");
                Console.ReadLine();
                Game();
            }
            else if (UserInput != correctAnswer)
            {
                PointCounter--;
                Console.WriteLine($"Unfortunately it was not {UserInput}, but {correctAnswer}.");
                Console.ReadLine();
                Game();
            }
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
