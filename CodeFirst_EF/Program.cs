using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CodeFirst_EF.Model;

namespace CodeFirst_EF
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var db = new DataContext())
            {
                var student = new Student() { StudentName="Jon" };
                var subject1 = new Subject() { SubjectName ="Math" };
                var subject2 = new Subject() { SubjectName = "Science" };

                student.Subjects.Add(subject1);
                student.Subjects.Add(subject2);

                db.Students.Add(student);
                db.SaveChanges();

            }
        }
    }
}
