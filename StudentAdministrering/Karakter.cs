using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentAdministrering
{
    internal class Karakter
    {
        public Student _student { get; private set; }
        public Fag _fag { get; private set; }
        public string _karakterVerdi { get; private set; }

        public Karakter(Student student, Fag fag, string karakterVerdi)
        {
            _student = student;
            _fag = fag;
            _karakterVerdi = karakterVerdi;
        }
        public void SkrivUtInfo()
        {
            Console.WriteLine($"Student: {_student._studentNavn}\nFag: {_fag._fagNavn}\nKarakter: {_karakterVerdi}\n");
        }
    }
}
