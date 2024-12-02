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
        public int _studentID { get; private set; }


        public void FåAllInfo(Student student)
        {
            student.SpørOmNavn();
            student.SpørOmAlder();
            student.SpørOmStudieRetning();
            student.GiEnID();
        }
        public void SkrivUtInfo()
        {
            Console.WriteLine($"Student: {_studentNavn}\nAlder: {_studentAlder}\nStudie: {_studieRetning}\nID: {_studentID}\n");
        }

        void SpørOmNavn()
        {
            Console.Write("Skriv inn studentens navn: ");
            string navnInput = Console.ReadLine();
            _studentNavn = navnInput;
        }

        void SpørOmAlder()
        {
            Console.Write("Skriv inn studentens alder: ");
            int.TryParse(Console.ReadLine(), out int alderInput);
            _studentAlder = alderInput;
        }

        void SpørOmStudieRetning()
        {
            Console.Write("Skriv studieretning: ");
            string retningInput = Console.ReadLine();
            _studieRetning = retningInput;
        }

        void GiEnID()
        {
            Random generertIDNummer = new Random();
            int nyStudentID = generertIDNummer.Next(1, 1000);
            _studentID = nyStudentID;
        }       
    }
}
