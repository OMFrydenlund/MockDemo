using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FriendFace
{
    internal class ProfileModel
    {
        public string UserName { get; private set; }
        public string Password { get; private set; }
        private bool OnlineStatus;
        public List<ProfileModel> FriendList;

        private string Name;
        private int Age;
        private string AboutMe;

        public ProfileModel(string userName, string name, int age, string basicInfo, string password)
        {
            UserName = userName;
            Name = name;
            Age = age;
            AboutMe = basicInfo;
            Password = password;
        }     
        public void PrintProfileInfo()
        {
            Console.WriteLine($"Name: {Name}, {Age}\nAbout me: {AboutMe}\n\n");
        }
        private void PrintListedFriends()
        {
            Console.Clear();
            int counter = 0;
            foreach (ProfileModel f in FriendList)
            {
                counter++;
                Console.WriteLine($"{counter}. {f.Name}");
            }
        }
        public void ViewFriendList()
        {
            Console.Clear();
            Console.WriteLine("Current friends:");
            if (FriendList.Count == 0)
            {
                Console.WriteLine("No friends have been added yet!");
            }
            else
            {
                foreach (ProfileModel f in FriendList)
                {
                    f.PrintProfileInfo();
                }
            }
            EnterToContinue();
            Console.ReadLine();
        }
        public void PromptFriendRemoval()
        {
            Console.Clear();
            Console.WriteLine("Remove which friend?\n");
            PrintListedFriends();

            int whichIndex = int.Parse(Console.ReadLine()) - 1;
            Console.WriteLine($"{FriendList[whichIndex].Name} has been removed.");
            FriendList.RemoveAt(whichIndex);

            Console.ReadLine();
        }
        private void EnterToContinue()
        {
            Console.WriteLine("Press Enter to exit list view.");
        }
        private void ErrorMessage()
        {
            Console.Clear();
            Console.WriteLine("Error has occured");
            Thread.Sleep(1500);
            Console.Clear();
        }
    }
}
