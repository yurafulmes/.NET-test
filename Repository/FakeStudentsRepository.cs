using InternshipTest;
using InternshipTest.Person;
using System;
using System.Collections.Generic;
using System.Text;

namespace internshiptest.Repository
{
    class FakeStudentsRepository
    {
        private IList<Student> _students;
        public FakeStudentsRepository()
        {
            _students = Seed();
        }
        private IList<Student> Seed()
        {
            return new List<Student>(){
                new Student("Andrew Kostenko", new Knowledge(1)),
                new Student("Julia Veselkina", new Knowledge(3)),
                new Student("Maria Perechrest", new Knowledge(2))
            };
        }
        public IEnumerable<Student> GetAll()
        {
            return _students;
        }

    }
}
