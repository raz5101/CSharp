using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module8Assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            //declare variables
            Student myStudent1 = new Student("Bob", "Jones", new DateTime(1955, 5, 2), 12);
            Student myStudent2 = new Student("John", "Doe", new DateTime(1969, 7, 11), 22);
            Student myStudent3 = new Student("Jayne", "Mansfield", new DateTime(1977, 3, 1), 15);
            Teacher myTeacher = new Teacher("Bernie", "Cunningham", new DateTime(1969, 7,11), "Mathematics", "PhD");
            UProgram myProgram = new UProgram("Information Technology");
            Degree myDegree = new Degree("Bachelor of Science");
            Course myCourse = new Course("Programming in C#");

            myProgram.degree = myDegree;
            myDegree.course = myCourse;

            //add students to course
            myCourse.students.Add(myStudent1);
            myCourse.students.Add(myStudent2);
            myCourse.students.Add(myStudent3);

            //add grades to students
            Stack<int> grades1 = myStudent1.Grades;
            Stack<int> grades2 = myStudent2.Grades;
            Stack<int> grades3 = myStudent3.Grades;

            grades1.Push(95);
            grades1.Push(98);
            grades1.Push(88);
            grades1.Push(90);
            grades1.Push(91);

            grades2.Push(87);
            grades2.Push(88);
            grades2.Push(83);
            grades2.Push(85);
            grades2.Push(84);

            grades3.Push(91);
            grades3.Push(90);
            grades3.Push(89);
            grades3.Push(92);
            grades3.Push(88);

            //output
            myCourse.ListStudents();
            myStudent1.getAge();
            myStudent2.getAge();
            myStudent3.getAge();
            pauseScreen();
        }

        static void pauseScreen()
        {
            Console.WriteLine();
            Console.WriteLine("Please press any key to continue...");
            Console.ReadKey();
        }
    }
}
