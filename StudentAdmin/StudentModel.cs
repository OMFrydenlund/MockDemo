using System;
using System.Collections.Generic;
using System.Linq;
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
        public List<SubjectModel> StudentSubjects;

        public StudentModel(string name, int age, string courseName, int studentID)
        {
            StudentSubjects = new List<SubjectModel>();
            Name = name;
            Age = age;
            CourseName = courseName;
            StudentID = studentID;
        }

        public void PrintStudentInfo()
        {
            Console.Write($"{StudentID}:{Name}, {Age}\nCourse: {CourseName}\n\n");
        }
    }
}
