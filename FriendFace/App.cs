using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FriendFace
{
    internal class App
    {
        private List<Profile> Users;
        public App()
        {
            Users = new List<Profile>()
            {
                new Profile("Pea", 24, "Bahamas", "I like to run from da gus. Also sam etens, sleppens an slappens", "OhNoes21"),
                new Profile("Nudal", 67, "Felpenus", "Who facken tuk sock AGAN dud", "ShrimpSandwich89"),
                new Profile("Bubbos", 250, "P ketchin", "Maow", "maowmeow")
            };
        }
        public void Run()
        {
            WelcomeMessage();
            UserLogIn();

            Console.ReadLine();
        }
        private void WelcomeMessage()
        {
            Console.WriteLine("Welcome to Friend Face!\n***********************\n");
            Thread.Sleep(1000);
        }
        private void UserLogIn()
        {
            bool profileExists = false;           
            do
            {
                var (loginName, loginPass) = GetLoginDetails();
                profileExists = VerifyExistingProfile(loginName, loginPass);
            } while (profileExists == false);

            //welcome and activate a profile based on the details of succesful login
        }
        private (string, string) GetLoginDetails()
        {
            Console.Write("Please type in your name and password: \n> ");
            string nameInput = Console.ReadLine();
            Console.Write("> ");
            string passwordInput = Console.ReadLine();

            return (nameInput, passwordInput);
        }
        private bool VerifyExistingProfile(string nameInput, string passwordInput)
        {
            bool exists = false;
            for (int i = 0; i < Users.Count; i++)
            {
                if (Users[i].Name == nameInput && Users[i].Password == passwordInput)
                {
                    exists = true;
                    i = Users.Count; //force loop ending            
                }
                else
                {
                    i = Users.Count;
                    LogInError();
                }
            }
            return exists;
        }
        private void LogInError()
        {
            Console.Clear();
            Console.WriteLine("Wrong name or password...");
            Thread.Sleep(1500);
            Console.Clear();
        }
    }
}
