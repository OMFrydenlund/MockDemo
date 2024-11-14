using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI
{
    internal class RandomHobby
    {
        public static void HobbyGenerator()
        {           
            Console.Write("Who wishes for a new hobby: ");
            string userName = Console.ReadLine();
            
            GenerateASingleHobby(userName);
        }

        static void GenerateASingleHobby(string name)
        {
            Console.Clear();

            Random generateHobby = new Random();
            int randomlySelected = generateHobby.Next(0, 4);

            if (randomlySelected == 0)
            {
                Console.WriteLine($"{name} is a photographer. Beaches are off limits, by the way.");
            }
            else if (randomlySelected == 1)
            {
                Console.WriteLine($"Ah, the great outdoors. Perfect for climbers like {name}...");
            }
            else if (randomlySelected == 2)
            {
                Console.WriteLine($"You're not really a hobby astronaut, {name}. Wait, ARE you?");
            }
            else if (randomlySelected == 3)
            {
                Console.WriteLine($"The fish enjoy their natural habitat. Right until {name} comes along with " +
                    $"god damned fishing gear, that is.");
            }
            else
            {
                Console.WriteLine($"A hobby demon? Where did I put my holy wAAAAtyyYuiOp....\n\n\n\n\n\n\n\n\n (:<");
            }
        }
    }
}
