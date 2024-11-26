using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentAdministrering
{
    internal class Student
    {
        public string _studentNavn { get; private set; }
        public int _studentAlder { get; private set; }
        public string _studieRetning { get; private set; }
        public int _studentID { get; set; }

        public string SpørOmNavn()
        {
            Console.Clear();
            Console.Write("Hva heter studenten? ");
            string navnInput = Console.ReadLine();
            return navnInput;
        }

        public int SpørOmAlder()
        {
            Console.Clear();
            Console.Write("Hvor gammel studenten? ");
            int.TryParse(Console.ReadLine(), out int alderInput);
            return alderInput;
        }

        public string SpørOmStudieRetning()
        {
            Console.Clear();
            Console.Write("Hvilken studieretning skal tas opp? ");
            string retningInput = Console.ReadLine();
            return retningInput;
        }

        public int GiEnID()
        {
            Random random = new Random();
            int nyID = random.Next(1, 250);
            return nyID;
        }
        public void SkrivUtInfo()
        {
            Console.Clear();
            Console.WriteLine($"Navn: {_studentNavn}\nAlder: {_studentAlder}\nProgram: {_studieRetning}\nID nummer: {_studentID}");
        }
    }
}
