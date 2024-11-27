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

        public Student()
        {
            
        }

        public Student(string studentNavn, int studentAlder, string studieRetning, int studentID)
        {
            _studentNavn = studentNavn;
            _studentAlder = studentAlder;
            _studieRetning = studieRetning;
            _studentID = studentID;            
        }

        public void SpørOmNavn()
        {
            Console.Clear();
            Console.Write("Hva heter studenten? ");
            string navnInput = Console.ReadLine();
            _studentNavn = navnInput;
        }

        public void SpørOmAlder()
        {
            Console.Clear();
            Console.Write("Hvor gammel studenten? ");
            int.TryParse(Console.ReadLine(), out int alderInput);
            _studentAlder = alderInput;
        }

        public void SpørOmStudieRetning()
        {
            Console.Clear();
            Console.Write("Hvilken studieretning skal tas opp? ");
            string retningInput = Console.ReadLine();
            _studieRetning = retningInput;
        }

        public void GiEnID()
        {
            // generer ny random ID
            int nyID = 1504962;
            _studentID = nyID;
        }
        public void SkrivUtInfo()
        {
            Console.Clear();
            Console.WriteLine($"Student: {_studentNavn}\nAlder: {_studentAlder}\nStudie: {_studieRetning}\nID: {_studentID}");
        }
    }
}
