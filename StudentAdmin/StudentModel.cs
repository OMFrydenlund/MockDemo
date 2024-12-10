using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace StudentAdmin
{
    internal class StudentModel
    {
        /*
         * Egenskaper: Navn, Alder, Studieprogram, StudentID.
            Metode: `SkrivUtInfo()` som skriver ut informasjon om studenten.
        */

        public string Name;
        public int Age;
        public string CourseName;
        public int StudentID;
        private Random IDGenerator = new Random();
        public List<SubjectModel> StudentSubjectList;

        private List<SubjectModel> ArtSubjects = new List<SubjectModel>
        {
            new SubjectModel("Col50", "Colors", 12),
            new SubjectModel("Sha35", "Shadows", 15),
            new SubjectModel("Ang20", "Angles", 12)
        };

        private List<SubjectModel> ScienceSubjects = new List<SubjectModel>
        {
            new SubjectModel("Ph10", "Physics", 15),
            new SubjectModel("Ma35", "Math", 10),
            new SubjectModel("Co55", "Cooking", 25)
        };      

        public StudentModel()
        {
            
        }
        public StudentModel(string name, int age, string courseName, int studentID)
        {
            StudentSubjectList = new List<SubjectModel>();           
            Name = name;
            Age = age;
            CourseName = courseName;
            StudentID = studentID;
        }

        public void GetStudentInfo(StudentModel student)
        {
            AutoGenerateID(student);
            GetName(student);
            GetAge(student);
            GetCourse(student);
            AssignMainCourse(student);
        }

        private void AutoGenerateID(StudentModel student)
        {
            student.StudentID = IDGenerator.Next(1, 550);
        }

        private void GetName(StudentModel student)
        {
            Console.Write("Student name: ");
            student.Name = Console.ReadLine();
        }

        private void GetAge(StudentModel student)
        {        
            Console.Write("Student age: ");
            student.Age = int.Parse(Console.ReadLine());
        }

        private void GetCourse(StudentModel student)
        {
            Console.Write("Course: ");
            CourseName = Console.ReadLine();
        }


        private void AssignMainCourse(StudentModel student)
        {
            Console.WriteLine("");
            Console.Write("Assign to major: \n1. Arts\n2. Science\n");
            string choice = Console.ReadLine();
            switch (choice)
            {
                case "1":
                    student.StudentSubjectList = ArtSubjects;
                    break;
                case "2":
                    student.StudentSubjectList = ScienceSubjects;
                    break;
                default:
                    Console.WriteLine("Not a valid choice.");
                    break;
            }
        }

        public void PrintStudentInfo()
        {
            Console.Write($"{StudentID}: {Name}, {Age}\nCourse: {CourseName}\n\n");
        }
    }
}
