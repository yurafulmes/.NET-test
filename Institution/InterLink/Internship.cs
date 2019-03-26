using InternshipTest.Person;
using System.Collections.Generic;

namespace InternshipTest.Institution.InterLink
{
    public class Internship
    {
        public string Name { get; }
        private IList<Student> Students { get; }
        public Internship(string name, University university = null /*for flexibility can be an interface*/)
        {
            Name = name;

            if (university != null)
                Students = university.filterByAverageKnowledge();
            else
                Students = new List<Student>();//for default

        }

        public string GetStudents()
        {
            string result = "";

            foreach (var student in Students)
            {
                result += student.Name;
                result += "\n";//split
            }
            return result;
        }
    }
}
