using System;
using InternshipTest.Person;
using InternshipTest.Institution;
using InternshipTest.Institution.InterLink;
using internshiptest.Repository;
using System.Linq;

namespace InternshipTest
{
    class Program
    {
        static void Main(string[] args)
        {
            University university = new University("CH.U.I.", new FakeStudentsRepository().GetAll().ToList());

            Internship internship = new Internship("Interlink", university);
            Console.WriteLine("List of internship's students:");
            Console.WriteLine(internship.GetStudents());

            Console.ReadKey();
        }
    }
}
