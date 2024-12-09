using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentAdmin
{
    internal class GradeModel
    {
        /*
         * Egenskaper: Student (referanse til en Student), Fag (referanse til et Fag), Karakterverdi.
           Metode: `SkrivUtInfo()` som skriver ut informasjon om karakteren.
         */
        public string GradedStudent;
        public string GradedSubject;
        int Grade;

        public GradeModel(StudentModel student, SubjectModel subject, int grade)
        {
            GradedStudent = student.Name;
            GradedSubject = subject.SubjectName;
            Grade = grade;
        }

        public void PrintGradeInfo()
        {
            Console.Write($"{GradedStudent}: {GradedSubject} {Grade}\n");
        }
    }
}
