using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace PracticeQuetions1
{
    /* 13. Suppose that we are required to model “students and teachers” record in the application. Design the classes with following specifications:
a.	Define a super class called Person to store common properties such as name and address.
b.	Define subclasses Student and Teacher for their specific properties. 
c.	For students, we need to maintain the courses taken and their respective grades.
d.	For teachers, we need to maintain the courses taught currently, and able to add or remove a course taught. 
e.	Define the class to print the students with their course wise grades and the list of teachers and their allotted courses.
 */

    class Person
    {
        protected string name { get; set; }
        protected string address { get; set; }

        protected Person(string name, string address)
        {
            this.name = name;
            this.address = address;
        }
    }

    class STUdent : Person
    {
        internal Dictionary<string,char> courseAndGrade { get; set; }

        internal STUdent(string name, string address) : base(name, address)
        {
            courseAndGrade = new Dictionary<string, char>();
        }

        internal void PrintStudentDetails()
        {
            Console.WriteLine($"Student: {name}, Address: {address}");
            Console.WriteLine("Courses and Grades:");
            foreach (var course in courseAndGrade)
            {
                Console.WriteLine($"{course.Key}: {course.Value}");
            }
            Console.WriteLine();
        }
    }

    class Teacher : Person
    {
        internal List<string> CoursesTaught { get; set; }

        internal Teacher(string name, string address) : base(name, address)
        {
            CoursesTaught = new List<string>();
        }

        internal void AddCourseTaught(string course)
        {
            CoursesTaught.Add(course);
        }

        internal void RemoveCourseTaught(string course)
        {
            CoursesTaught.Remove(course);
        }

        internal void PrintTeacherDetails()
        {
            Console.WriteLine($"Teacher: {name}, Address: {address}");
            Console.WriteLine("Courses Taught:");
            foreach (var course in CoursesTaught)
            {
                Console.WriteLine(course);
            }
            Console.WriteLine();
        }

    }

    internal class Que13
    {
        
        internal void print()
        {
            STUdent stu = new STUdent("Omkar", "Wadgaon");
            stu.courseAndGrade.Add("Math", 'A');
            stu.courseAndGrade.Add("Science", 'B');

            STUdent stu2 = new STUdent("Akshay", "Iskon");
            stu2.courseAndGrade.Add("Math", 'C');
            stu2.courseAndGrade.Add("Science", 'B');

            Teacher tea = new Teacher("Anu Mam", "Noida");
            tea.AddCourseTaught("English");
            tea.AddCourseTaught("History");

            Teacher tea2 = new Teacher("Kulkarni Mam", "Pune");
            tea2.AddCourseTaught("Marathi");
            tea2.AddCourseTaught("Arts");

            stu.PrintStudentDetails();
            stu2.PrintStudentDetails();
            tea.PrintTeacherDetails();
            tea2.PrintTeacherDetails();

            tea2.RemoveCourseTaught("Arts");
            tea2.PrintTeacherDetails();

        }        

    }
}
