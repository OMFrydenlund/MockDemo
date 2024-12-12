using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextManipulator
{
    internal class TextManipulatorClass
    {
        public static void PlayWithText()
        {
            Console.WriteLine("Today we'll be manipulating texts. Which way would you prefer?" +
                "\n\n1) Rotate a text\n2) Replace a's with e's");
            int.TryParse(Console.ReadLine(), out int userChoice);

            ChoiceCheck(userChoice);
        }

        static void ChoiceCheck(int userChoice)
        {
            if (userChoice == 1)
            {
                SentenceReversal();
            }
            else if (userChoice == 2)
            {
                SentenceConversion();
            }
            else
            {
                Console.WriteLine("Invalid choice. Press enter to continue...");
                Console.ReadLine();
                ChoiceCheck(userChoice);
            }
        }

        static void SentenceReversal()
        {
            Console.Clear();
            Console.Write("What word/sentence would you like to reverse: ");
            string userStringInput = Console.ReadLine();
            ReverseText(userStringInput);
        }

        static void SentenceConversion()
        {
            Console.Clear();
            Console.Write("Write something that needs to replace e's with a's: ");
            string userStringInput = Console.ReadLine();
            ReplaceLetters(userStringInput);
        }


        static void ReverseText(string sentence)
        {
            //start loop at string's end, i >=0 to also include first letter in index (0), loop backwards (--)
            for (int i = sentence.Length - 1; i >= 0; i--)
            {
                Console.Write(sentence[i]);
            }

        }

        static void ReplaceLetters(string sentence)
        {
            //small cheat converting string into all lower case
            //revisit to add lower/upper case differentiation
            string sentenceToFormat = sentence.ToLower();
            foreach (char c in sentenceToFormat)
            {
                if (c == 'e')
                {
                    Console.Write('a');
                }
                else
                {
                    Console.Write(c);
                }
            }
        }
    }
}
