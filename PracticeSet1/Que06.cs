using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeQuetions1
{
    //6. Write a program in C# to read the following information from the keyboard in which the base class consists of employee name, code and designation. The derived class Manager which contains the data members namely, year of experience and salary. Display the whole information on the screen.

    class Employee
    {
        protected string name;
        protected int code;
        protected string designation;

        protected Employee(string name, int code, string designation)
        {
            this.name = name;
            this.code = code;
            this.designation = designation;
        }
    }

    class Manager : Employee
    {
        protected internal string name;
        protected internal int experience;
        protected internal float salary;

        public Manager(string name, int code, string designation, int experience, float salary) : base(name, code, designation)
        {
            this.name = name;
            this.experience = experience;
            this.salary = salary;
        }

        internal void displayInfo()
        {
            Console.WriteLine($"\n\n'Employee Information'" +
                $"\nName : {name}" +
                $"\nCode : {code}" +
                $"\nDesignation : {designation}" +
                $"\nYear of Experience : {experience}" +
                $"\nSalary : {salary}");

        }
    }

    internal class Que06
    {
        internal void menu()
        {
            Console.WriteLine("Enter Employee Details - ");
            Console.Write("Name : ");
            string name = Console.ReadLine();
            Console.Write("Code : ");
            int code = Convert.ToInt32(Console.ReadLine());
            Console.Write("Designation : ");
            string designation = Console.ReadLine();
            Console.Write("Year of Experience : ");
            int yofEx = Convert.ToInt32(Console.ReadLine());
            Console.Write("Salary : ");
            float salary = Convert.ToSingle(Console.ReadLine());

            Manager m = new Manager(name, code, designation, yofEx, salary);
            m.displayInfo();
        }
    }
}
