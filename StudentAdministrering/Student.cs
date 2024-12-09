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
        public List<Fag> _studentFagListe { get; set; }

        public Student()
        {
            _studentFagListe = new List<Fag>();
        }

        public void OpprettStudentInfo(Student student)
        {
            student.SpørOmNavn();
            student.SpørOmAlder();
            student.SpørOmStudieRetning();
            student.GiEnID();
            student.FyllStudentFagListe();
        }
        public void SkrivUtInfo()
        {
            
            Console.Write($"ID {_studentID}: {_studentNavn}, {_studentAlder} år\nRetning: {_studieRetning}" +
                $"\nFag: ");
            if (_studentFagListe == null)
            {
                Console.Write("Ingen registrerte fag.");
            }
            else
            {
                //fiks legg til fag først
                //når siste index blir printet, hvordan skal du la vær å ta med en ", " 
                foreach (Fag fag in _studentFagListe)
                {
                    Console.Write($"{fag._fagNavn}" + ", ");
                }
            }           
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
        
        void FyllStudentFagListe()
        {
            Console.Write($"\nLegg til fag for {_studentNavn}?\n1. Ja\n2. Nei\n\n");
            string input = Console.ReadLine();
            switch (input)
            {
                case "1":
                    // opprette fag, me
                    break;
                case "2":
                    break;
                default:
                    Console.Clear();
                    Console.WriteLine("Ikke et gyldig valg");
                    Thread.Sleep(2000);
                    Console.Clear();
                    break;
            }
        }
    }
}
