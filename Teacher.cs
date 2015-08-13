using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module8Assignment
{
    class Teacher : Person
    {
        public string major { get; set; }
        public string credentials { get; set; }

        public void gradeTest()
        {
            Console.WriteLine("Grade the test");
        }

        public Teacher(string firstName, string lastName, DateTime birthDate, string major, string credentials)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.birthDate = birthDate;
            this.major = major;
            this.credentials = credentials;
        }
    }
}
