using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentAdmin
{
    internal class AppClass
    {       
        List<StudentModel> Students;
        public AppClass()
        {
            Run();
        }

        private void Run()
        {
            Students = new List<StudentModel>()
            {                
                new StudentModel("Terry", 19, "Arts", 160),
                new StudentModel("Elin", 20, "Sciences", 320),
                new StudentModel("Colin", 17, "Arts", 550)
            };
            MainMenu();
                        

            Console.ReadLine();
        }
        
        private void MainMenu()
        {
            bool inMainMenu = true;
            while (inMainMenu)
            {
                Console.Clear();
                Console.Write("What would you like to do: \n1. Add a student\n2. Assign grades\n3. View more information\n");
                string choice = Console.ReadLine();
                switch (choice)
                {
                    case "1":
                        AddStudent();
                        break;
                    case "2":
                        GradeMenu();
                        break;
                    case "3":
                        //View info
                        break;
                    case "4":
                        //Exit app
                        break;
                    default:
                        //Invalid choice
                        break;
                }
            }           
        }

        private void AddStudent()
        {
            Console.Clear();
            StudentModel newStudent = new StudentModel();
            newStudent.GetStudentInfo(newStudent);          
            Students.Add(newStudent);
        }    
        
        private void GradeMenu()
        {
            //what is in GM
            Console.Clear();
            if (Students.Count == 0)
            {
                NoRegisteredStudents();
            }
            else
            {
                /*
                 * choose students > choose subjects > call grade assignment method > back to main/previous menu
                 */
                Console.Clear();
                Console.Write("Choose student: \n");
                int counter = 1;
                foreach (StudentModel s in Students)
                {
                    Console.WriteLine($"{counter} {s.Name}");
                    counter++;
                }
            }
            Console.ReadLine();
        }

        private void NoRegisteredStudents()
        {
            Console.Clear();
            Console.WriteLine("There are no registered students.");
            Thread.Sleep(1500);
            Console.Clear();
        }

        private void PrintFullStudentList()
        {
            foreach (StudentModel s in Students)
            {
                s.PrintStudentInfo();
            }
        }
    }
}
