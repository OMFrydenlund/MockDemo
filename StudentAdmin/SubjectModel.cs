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
         */

        public string SubjectCode;
        public string SubjectName;
        public int SubjectCredits;

        public SubjectModel(string subjectCode, string subjectName, int subjectCredits)
        {
            SubjectCode = subjectCode;
            SubjectName = subjectName;
            SubjectCredits = subjectCredits;
        }

        public void PrintSubjectInfo()
        {
            Console.Write($"{SubjectCode}: {SubjectName}, {SubjectCredits} points\n\n");
        }
    }
}
