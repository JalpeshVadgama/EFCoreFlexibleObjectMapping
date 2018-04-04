using System;
using System.Collections.Generic;
using System.Linq;

namespace EFCore2Mapping
{
    class Program
    {
        static void Main(string[] args)
        {

            List<Student> ExistingStudents = new List<Student>();

            Student student = new Student
            {
                FirstName = "Teerth",
                LastName = "Vadgama",
            };
            student.AssignStandard("5");
            student.AssignDivision("A");

            using (StudentContext studentConext = new StudentContext())
            {
                ///Adding a new Student;
                studentConext.Student.Add(student);
                studentConext.SaveChanges();


                ///Retriviting newly added student
                ExistingStudents = studentConext.Student.ToList();
                
            }

            foreach(Student s in ExistingStudents)
            {
                Console.WriteLine($"Student Id: {s.StudentId}");
                Console.WriteLine($"First Name: {s.FirstName}");
                Console.WriteLine($"Last Name:{s.LastName}");
                Console.WriteLine($"Standard:{s.GetStandard()}");
                Console.WriteLine($"Division:{s.GetDivision()}");
            }
        }
    }
}
