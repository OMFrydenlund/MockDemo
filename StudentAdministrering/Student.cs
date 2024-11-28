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

        public void SpørOmAllStudentInfo(Student student)
        {
            student.SpørOmNavn();
            student.SpørOmAlder();
            student.SpørOmStudieRetning();
            student.GiEnID();
        }

        public void SpørOmNavn()
        {
            Console.Write("Hva heter studenten? ");
            string navnInput = Console.ReadLine();
            _studentNavn = navnInput;
        }

        public void SpørOmAlder()
        {
            Console.Write("Hvor gammel studenten? ");
            int.TryParse(Console.ReadLine(), out int alderInput);
            _studentAlder = alderInput;
        }

        public void SpørOmStudieRetning()
        {
            Console.Write("Hvilken studieretning skal tas opp? ");
            string retningInput = Console.ReadLine();
            _studieRetning = retningInput;
        }

        public void GiEnID()
        {
            Random generertIDNummer = new Random();
            int nyStudentID = generertIDNummer.Next(1, 1000);
            _studentID = nyStudentID;
        }
        public void SkrivUtInfo()
        {
            Console.WriteLine($"Student: {_studentNavn}\nAlder: {_studentAlder}\nStudie: {_studieRetning}\nID: {_studentID}\n");
        }
    }
}
