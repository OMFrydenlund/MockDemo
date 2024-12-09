using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentAdministrering
{
    internal class StudentAdminApp
    {
        public StudentAdminApp()
        {           
            bool skoleAdministrering = true;

            List<Student> studentListe = new List<Student>();
            List<Fag> fagListe = new List<Fag>() //generell liste for fag innenfor en app-instanse
            {
                // fyll med fagobjekter
            };
            while (skoleAdministrering)
            {                
                Console.Clear();
                Console.Write("Velg handling:\n1. Studentbehandling\n2. Fagbehandling\n3. Avslutt program\n\n");
                string valgInput = Console.ReadLine();
                switch (valgInput)
                {
                    case "1":
                        StudentBehandling(studentListe);
                        break;
                    case "2":
                        FagBehandling(fagListe);
                        break;
                    case "3":
                        AvsluttApp();
                        break;
                    default:
                        Console.Clear();
                        Console.WriteLine("Ikke et gyldig valg.\n");
                        Thread.Sleep(2000);
                        Console.Clear();
                        break;
                }
            }                  
        }
        // valg for studentbehandling-------------------
        void StudentBehandling(List<Student> studentListe)
        {
            Console.Clear();
            Console.Write("1. Legg til student\n2. Vis studentliste\n3. Gå tilbake\n\n");
            string input = Console.ReadLine();
            switch (input)
            {
                case "1":
                    Console.Clear();
                    LeggTilStudent(studentListe);
                    break;
                case "2":
                    Console.Clear();
                    ErDetNoeIListen(studentListe);                    
                    break;
                case "3":
                    Console.Clear();
                    break;
                default:
                    Console.Clear();
                    Console.WriteLine("Ikke et gyldig valg.\n");
                    Thread.Sleep(2000);
                    Console.Clear();
                    StudentBehandling(studentListe);
                    break;
            }
        }
        void LeggTilStudent(List<Student> studentListe)
        {
            Console.Clear();
            Student nyStudent = new Student();
            nyStudent.OpprettStudentInfo(nyStudent);
            studentListe.Add(nyStudent);
            Console.WriteLine($"\n{nyStudent._studentNavn} har blitt lagt til som student.\n");
            Console.ReadLine();
        }
        void SkrivUtStudentInfo(List<Student> studenter)
        {
            Console.Clear();
            foreach (Student s in studenter)
            {
                s.SkrivUtInfo();
            }
            Console.ReadLine();
        }

        //valg for fagbehandling------------------
        void FagBehandling(List<Fag> fagListe)
        {
            Console.Clear();
            Console.Write("1. Legg til fag\n2. Vis fagliste\n3. Gå tilbake\n\n");
            string input = Console.ReadLine();
            switch (input)
            {
                case "1":
                    Console.Clear();
                    LeggTilFag(fagListe);
                    break;
                case "2":
                    Console.Clear();
                    ErDetNoeIListen(fagListe);                    
                    break;
                case "3":
                    Console.Clear();
                    break;
                default:
                    Console.Clear();
                    Console.WriteLine("Ikke et gyldig valg.\n");
                    Thread.Sleep(2000);
                    Console.Clear();
                    FagBehandling(fagListe);
                    break;
            }
        }

        void LeggTilFag(List<Fag> fagListe)
        {
            Console.Clear();
            Fag nyttFag = new Fag();
            nyttFag.OpprettFagInfo(nyttFag);
            fagListe.Add(nyttFag);
            Console.WriteLine($"\n{nyttFag._fagNavn} har blitt lagt til i faglisten.\n");
            Console.ReadLine();
        }

        void SkrivUtFagInfo(List<Fag> fagListe)
        {
            Console.Clear();
            foreach (Fag f in fagListe)
            {
                f.SkrivUtInfo();
            }
            Console.ReadLine();
        }

        // checkers ----------------

        void ErDetNoeIListen(List<Student> studentListe)
        {
            if (studentListe.Count == 0)
            {
                Console.Clear();
                Console.WriteLine("Det er ingen registrerte studenter.");
                Thread.Sleep(2000);
                Console.Clear();
            }
            else
            {
                SkrivUtStudentInfo(studentListe);
            }
        }

        void ErDetNoeIListen(List<Fag> fagListe)
        {
            if (fagListe.Count == 0)
            {
                Console.Clear();
                Console.WriteLine("Det er ingen registrerte fag.");
                Thread.Sleep(2000);
                Console.Clear();
            }
            else
            {
                SkrivUtFagInfo(fagListe);
            }
        }

        void AvsluttApp()
        {
            Console.Clear();
            Console.WriteLine("Avslutter programmet...");
            Thread.Sleep(2000);
            Environment.Exit(0);
        }
    }
}
