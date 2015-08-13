using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module8Assignment
{
    class Student : Person
    {
        public Stack<int> Grades = new Stack<int>();

        public int credits { get; set; }
       
        public void addCredits(int c)
        {
            credits += c;
            Console.WriteLine("{0} credits have been added to {1} {2}.", c, this.firstName, this.lastName);
        }

        public void showCredits()
        {
            Console.WriteLine("{0} {1} has earned {2} credits.", this.firstName, this.lastName, this.credits);
        }

        public void takeTest()
        {
            Console.WriteLine("Take the test");
        }

        public Student(string firstName, string lastName, DateTime birthDate, int credits)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.birthDate = birthDate;
            this.credits = credits;
        }

    }
}
