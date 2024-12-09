using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentAdmin
{
    internal class AppClass
    {
        /*
         * 1. Opprett minst to instanser av hver klasse (`Student`, `Fag`, `Karakter`).
           2. Sett verdier for egenskapene.
           3. Kall `SkrivUtInfo()`-metoden for hver klasse for å skrive ut informasjonen.
         */
        List<SubjectModel> ArtSubjects;
        List<SubjectModel> ScienceSubjects;
        public AppClass()
        {
            Run();
        }

        private void Run()
        {
            ScienceSubjects = new List<SubjectModel>()
            {
                new SubjectModel("Ph10", "Physics", 15),
                new SubjectModel("Ma35", "Math", 10),
                new SubjectModel("Co55", "Cooking", 25)
            };
            ArtSubjects = new List<SubjectModel>()
            {
                new SubjectModel("Col50", "Colors", 12),
                new SubjectModel("Sha35", "Shadows", 15),
                new SubjectModel("Ang20", "Angles", 12)
            };

            StudentModel bob = new StudentModel("Bob", 19, "Arts", 451);
            StudentModel elin = new StudentModel("Elin", 18, "Sciences", 331);

            //add grades, then print the info


            Console.ReadLine();
        }
    }
}
