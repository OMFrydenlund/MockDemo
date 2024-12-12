using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentAdmin
{
    internal class SubjectModel
    {
        /*
         * Egenskaper: Fagkode, Fagnavn, AntallStudiepoeng.
           Metode: `SkrivUtInfo()` som skriver ut informasjon om faget.

           Course > Major > Auxillary subjects
           
         */

        public string SubjectCode;
        public string SubjectName;
        public int SubjectCredits;
        public GradeModel SubjectGrade;
        public SubjectModel()
        {
            
        }
        public SubjectModel(string subjectCode, string subjectName, int subjectCredits)
        {
            SubjectCode = subjectCode;
            SubjectName = subjectName;
            SubjectCredits = subjectCredits;
            SubjectGrade = new GradeModel();     
        }

        public void AssignSubjectGrade()
        {
            Console.Clear();
            SubjectGrade = new GradeModel();
            Console.Write($"Assign a value for this student's {SubjectName} grade: ");
            SubjectGrade.Grade = Convert.ToDouble(Console.ReadLine());
            
        }

        public void PrintSubjectInfo()
        {
            //test after instantiating a subject with a given grade
            Console.Write($"{SubjectCode}: {SubjectName}, {SubjectCredits} points\n");
            SubjectGrade.PrintGradeInfo();
        }
    }
}
