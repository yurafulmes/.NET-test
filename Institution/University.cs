using InternshipTest.Person;
using System.Collections.Generic;
using System.Linq;

namespace InternshipTest.Institution
{
    public class University
    {
        public string Name { get; }
        public IList<Student> Students { get; }
        public University(string name, IList<Student> students = null)
        {
            Name = name;

            if (students == null)
                students = new List<Student>();//for default 

            Students = students;
        }
        public IList<Student> filterByAverageKnowledge()
        {
            var universityAverageKnowledge = GetAverageKnowledge();

            if (universityAverageKnowledge == null)
                return null;//do nothing
            else
                return Students.Where(s => s.Knowledge > universityAverageKnowledge).ToList();
        }
        public Knowledge GetAverageKnowledge()
        {
            if (Students == null)
                return null;
            else
                return new Knowledge(Students.Select(s =>
                { return s.Knowledge == null ? 0 : s.Knowledge.Level; }).Sum() / Students.Count);//calculate a mean value
        }
        public void AddStudent(Student student)
        {
            Students.Add(student);
        }
    }
}
