using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module8Assignment
{
    class Person
    {
        public string firstName { get; set; }
        public string lastName { get; set; }
        public DateTime birthDate { get; set; }

        public void getAge()
        {
            DateTime now = new DateTime();
            now = DateTime.Today;

            int age = now.Year - this.birthDate.Year;
            if (age > -1)
            {
                if (now.Month < this.birthDate.Month || (now.Month == this.birthDate.Month && now.Day < this.birthDate.Day)) age--;
                Console.WriteLine("{0} {1} is {2} years old.", this.firstName, this.lastName, age);
            }

        }
    }
}
