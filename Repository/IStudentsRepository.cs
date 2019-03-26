using InternshipTest.Person;
using System;
using System.Collections.Generic;
using System.Text;

namespace internshiptest.Repository
{
    interface IStudentsRepository
    {
        IEnumerable<Student> GetAll();
        //can be added update,delete,add,...
    }
}
