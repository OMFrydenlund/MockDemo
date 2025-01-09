using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FriendFace
{
    internal class Profile
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public string Location { get; set; }
        public string BioInfo { get; set; }
        public List<Profile> Friends { get; set; }
        public string Password { get; set; }

        public Profile(string name, int age, string location, string bioInfo, string password)
        {
            Name = name;
            Age = age;
            Location = location;
            BioInfo = bioInfo;
            Friends = new List<Profile>();
            Password = password;
        }
        public string GetName()
        {
            return Name;
        }
        public string GetPassword()
        {
            return Password;
        }
        public void PrintProfileInfo()
        {
            Console.Write($"{Name}, {Age} | Location: {Location}\n");
            PrintSeparator();
            //format bio info to a tile later
            Console.WriteLine($"\nAbout me: {BioInfo}\n\n");

        }

        private void PrintSeparator()
        {
            string lengthSetter = Name + ", " + Age.ToString() + " | Location: " + Location;
            foreach (char c in lengthSetter)
            {
                Console.Write("*");
            }
        }
    }
}
