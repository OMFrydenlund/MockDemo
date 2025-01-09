using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FriendFace
{
    internal class App
    {
        private List<ProfileModel> Users;
        /*
         * un/pw references:
         * 0 TimProf - tower15
         * 1 FourWinds - 1q2w3e
         * 2 JimBollocks1 - row91boat
         * 3 GrumpyEdgeLord51 - CoMpLiCaTeD1970
         */
        public App()
        {           
            Users = new List<ProfileModel>()
            {
                new ProfileModel("TimProf", "Tim", 54, "I'm a full time dev and professor.", "tower15"),
                new ProfileModel("FourWinds", "Maria", 27, "I study computer science.", "1q2w3e"),
                new ProfileModel("JimBollocks1", "Carl", 29, "I study finance.", "row91boat"),
                new ProfileModel("GrumpyEdgeLord51", "Eric", 45, "Part-time professor.", "CoMpLiCaTeD1970")
            };

            LoginPrompt();
            Console.ReadLine();
        }
        private void LoginPrompt()
        {
            string userName;
            string password;
            bool isLoggingIn = true;

            while (isLoggingIn)
            {
                Console.WriteLine("******FRIENDFACE******\n  Welcome to the app!\n\nType your username and password:");
                Console.Write("Username: ");
                userName = Console.ReadLine();
                Console.Write("Password: ");
                password = Console.ReadLine();
                if (CheckLoginCredentials(userName, password))
                {
                    Console.WriteLine($"Login successful, welcome {userName}!");
                    //clear console and intantiate selected profile
                }
                else
                {
                    Console.WriteLine("Login failed, please try again.");
                }
            }
           
        }
        private bool CheckLoginCredentials(string userName, string password)
        {
            foreach (var user in Users)
            {
                if (user.UserName == userName)
                {
                    if (user.Password == password)
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
            }
            return false;
        }
    }
}
