using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrganTransplant
{
    internal class Surgery
    {
        private List<string> SurgeryIntroLines = new List<string>()
        {
            "Entering emergency room... hold for a second.",
            "Bob and Carl are prepped.",
            "Commencing surgery."
        };       

        private Random randomProperty = new Random();
        private Bob BobInSurgery;
        private Carl CarlInSurgery;
        public Surgery(Bob bob, Carl carl)
        {
            Console.Clear();
            BobInSurgery = bob;
            CarlInSurgery = carl;

            PrintStoryLines();
            RunSurgeryScene();

            Console.ReadLine();            
        }

        private void PrintStoryLines()
        {
            foreach (string line in SurgeryIntroLines)
            {
                Console.WriteLine(line);
                Thread.Sleep(3500);
            }
        }

        private void RunSurgeryScene()
        {
            List<string> surgeryProgression = new List<string>()
            {
                $"Sanitizing {BobInSurgery.Name}'s wounds, stabilizing...",
                $"Preparing to remove 1 of {CarlInSurgery.Name}'s {CarlInSurgery.KidneyCount} kidneys.",
                $"{CarlInSurgery.Name} has {CarlInSurgery.KidneyCount - 1} left.",
                $"Transfering {CarlInSurgery.Name}'s kidney to {BobInSurgery.Name}.",
                $"Sanitizing and closing {CarlInSurgery.Name}'s wounds",
                $"Stabilizing...",
                $"Transplanting kidney into {BobInSurgery.Name}.",
                "Cleaning up...",
                "Stitching...",
                "Checking vitals...",
                "Surgery is a success! :)"
            };

            CarlInSurgery.KidneyCount -= 1;

            foreach (string line in surgeryProgression)
            {
                Console.WriteLine(line);
                Thread.Sleep(3500);
            }

            Console.Clear();
            Console.WriteLine($"{BobInSurgery.Name} has {BobInSurgery.KidneyCount + 1} functional kidneys now," +
                $" thanks to {CarlInSurgery.Name}. {CarlInSurgery.Name} has retained {CarlInSurgery.KidneyCount} kidney." +
                $" Thanks doc!");
            Thread.Sleep(5000);
            Console.Clear();

            Console.WriteLine("Well responded user, until next time...\n\n");
            Thread.Sleep(3500);
            Environment.Exit(0);

        }
    }
}
