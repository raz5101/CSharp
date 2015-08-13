using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module8Assignment
{
    class Course
    {
        public string courseName { get; set; }
        public List<Student> students = new List<Student>();
        public Teacher[] teachers { get; set; }
        public int studentCount { get; set; }

        public Course(string name)
        {
            this.courseName = name;
            teachers = new Teacher[1];
        }

        public void ListStudents()
        {
            Console.WriteLine("Student List");

            foreach(Student s in students)
            {
                Console.WriteLine("{0} {1}", s.firstName, s.lastName);
            }
        }
    }
}
