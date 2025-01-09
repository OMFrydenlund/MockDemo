using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrganTransplant
{
    internal class PostAccidentScenario
    {
        private Random RandomChoice = new Random();
        public PostAccidentScenario()
        {
            
        }

        public void RunScenarioIntro()
        {
            PrintNarratorGimmicks();
            PrintIntroLines();
            PostScenarioMenu();
        }

        private void PrintNarratorGimmicks()
        {
            Console.WriteLine("YOU FIND YOURSELF WALKING DOWN THE STREET.");
            Thread.Sleep(2500);
            Console.WriteLine("THEN SUDDENLY...");
            Thread.Sleep(2000);
            Console.Clear();
        }

        private void PrintIntroLines()
        {
            List<string> storyLineLines = new List<string>()
            {
                "There's been an accident... HUH?!",
                "Bob! Oh god!",
                "(Who the fuck is Bob...)",
                "Anyways, he's been part of a traffic incident.",
                "Checking his vitals...",
                "...he needs a new kidney!",
                "Luckily, his cousin Carl might be a valid donor."
            };

            foreach (string line in storyLineLines)
            {
                Console.WriteLine(line);
                Thread.Sleep(2500);
            }
            Console.WriteLine("");
        }

        private void PostScenarioMenu()
        {          
            while (true)
            {
                PostScenarioPrompt();
                string choice = Console.ReadLine();
                switch (choice)
                {
                    case "1":
                        RunSurgeryScenario();
                        break;
                    case "2":
                        NoSurgeryRIP();
                        break;
                    case "3":
                        GiveWheelToJesus();
                        break;
                    case "4":
                        ExitWithMessage();
                        break;
                    default:
                        PrintDefaultErrorMessage();
                        break;
                }
            }           
        }

        private void PostScenarioPrompt()
        {
            Console.Write("Send Bob to surgery?\n1. Yes\n2. No\n3. Shit i don't know, you choose\n4. I can't deal with this right now" +
                ", exit program\n");
        }
        private void RunSurgeryScenario()
        {
            Bob bob = new Bob();
            Carl carl = new Carl();
            Surgery newSurgery = new Surgery(bob, carl);
        }

        private void NoSurgeryRIP()
        {
            Console.Clear();
            List<string> storyLineLines = new List<string>()
            {
                "What have you done!",
                "Bob...",
                "BOB!!!",
                "He is no longer with us.",
                "Think upon your actions...",
                "...coward >;("
            };

            foreach (string line in storyLineLines)
            {
                Console.WriteLine(line);
                Thread.Sleep(2500);
            }
            Environment.Exit(0);
        }

        private void GiveWheelToJesus()
        {
            GiveWheelReaction();
            Console.Clear ();
            int choice = RandomChoice.Next(1, 2);
            switch (choice)
            {
                case 1:
                    Console.WriteLine("Luckily, Jesus ain't too interested in Bob. Let's go to surgery...");
                    Thread.Sleep(3500);
                    RunSurgeryScenario();
                    break;
                case 2:
                    Console.WriteLine("Jesus has apparently abandoned Bob to his fate... because of you.");
                    Thread.Sleep(3500);
                    NoSurgeryRIP();
                    break;
                default:                  
                    Console.WriteLine("This line should never be printed to console.");
                    break;
            }

        }

        private void GiveWheelReaction()
        {
            Console.Clear();
            Console.WriteLine("Are you actually out of your mind? Let JESUS take the wheel?\n");
            Thread.Sleep(3500);
            Console.WriteLine("Poor Bob, here we go...");
            Thread.Sleep(3500);
        }

        private void ExitWithMessage()
        {
            Console.Clear();
            List<string> exitLines = new List<string>()
            {
                "The paramedics will be here soon.",
                "You may leave...",
                "...coward >;("
            };

            foreach (string line in exitLines)
            {
                Console.Write(line);
                Thread.Sleep(1500);
            }
            Console.WriteLine("\n\n");

            Environment.Exit(0);
        }

        private void PrintDefaultErrorMessage()
        {
            Console.Clear();
            Console.Write("You can't press that!");
            Thread.Sleep(1500);
            Console.Clear();
        }
    }
}
