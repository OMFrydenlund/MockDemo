using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentAdministrering
{
    internal class Fag
    {
        public string _fagKode { get; private set; }
        public string _fagNavn { get; private set; }
        public int _antallStudiePoeng { get; private set; }

        public void OpprettFagInfo(Fag fag)
        {
            fag.HentFagKode();
            fag.HentFagNavn();
            fag.HentStudiePoeng();
        }
        public void SkrivUtInfo()
        {
            Console.WriteLine($"Kode: {_fagKode} {_fagNavn}\n{_antallStudiePoeng} studiepoeng\n");
        }

        void HentFagKode()
        {
            Console.Write("Skriv inn fagkoden: ");
            string input = Console.ReadLine();
            _fagKode = input;
        }

        void HentFagNavn()
        {
            Console.Write("Skriv in faget: ");
            string input = Console.ReadLine();
            _fagNavn = input;
        }

        void HentStudiePoeng()
        {
            Console.Write("Hvor mange poeng: ");
            int input = int.Parse(Console.ReadLine());
            _antallStudiePoeng = input;
        }       
    }
}
