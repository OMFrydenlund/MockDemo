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

        public Fag(string fagKode, string fagNavn, int antallStudiePoeng)
        {
            _fagKode = fagKode;
            _fagNavn = fagNavn;
            _antallStudiePoeng = antallStudiePoeng;
        }
        public void SkrivUtInfo()
        {
            Console.WriteLine($"Fagkode: {_fagKode}\nFag: {_fagNavn}\nStudiepoeng: {_antallStudiePoeng}\n");
        }
    }
}
