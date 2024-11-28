using StudentAdministrering;

List<Student> studenter = new List<Student>();

Student nyStudent = new Student();
nyStudent.SpørOmAllStudentInfo(nyStudent);
studenter.Add(nyStudent);

Student nyStudent2 = new Student();
nyStudent2.SpørOmAllStudentInfo(nyStudent2);
studenter.Add(nyStudent2);

Fag norsk = new Fag("No01", "Norsk", 10);
Fag engelsk = new Fag("En02", "Engelsk", 12);

Karakter norskKarakter = new Karakter(nyStudent, norsk, "B-");
Karakter engelskKarakter = new Karakter(nyStudent2, engelsk, "A+");

foreach (Student student in studenter)
{
    student.SkrivUtInfo();
}

norsk.SkrivUtInfo();
engelsk.SkrivUtInfo();

norskKarakter.SkrivUtInfo();
engelskKarakter.SkrivUtInfo();






Console.ReadLine();