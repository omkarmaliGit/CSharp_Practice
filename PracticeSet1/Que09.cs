using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace PracticeQuetions1
{
    /* 9. Design two base classes Student (roll_no, name, class) and Marks (mark[3]). Design one derived class Result (percentage, grade). Write a menu driven program with following options Add the details of ‘n’ students with marks. Display result of all students in descending order of percentage. */

    class STudent
    {
        protected int roll_no;
        protected string name;
        protected class Marks
        {
            int[] mark = new int[3];
            internal void addmarks()
            {
                for (int i = 0; i < 3; i++)
                {
                    Console.Write($"enter Subject {i + 1} Marks : ");
                    mark[i] = Convert.ToInt32(Console.ReadLine());
                }
            }

            internal void displaymarks()
            {
                for (int i = 0; i < 3; i++)
                {
                    Console.Write($"Subject {i + 1} marks :  {mark[i]}");
                }
            }
        }
    }
    class Result : STudent
    {
        internal float percentage;
        internal char grade;

        Marks mark;

        internal void addStudent()
        {
            Console.Write("enter RollNo. : ");
            roll_no = Convert.ToInt32(Console.ReadLine());
            Console.Write("enter Name : ");
            name = Console.ReadLine();
            mark = new Marks();
            mark.addmarks();
            percentage = Convert.ToSingle(Console.ReadLine());
            grade = Convert.ToChar(Console.ReadLine());
        }
         
        internal void showResult()
        {
            Console.WriteLine($"{roll_no}\n{name}");
            mark.displaymarks();
            Console.WriteLine($"{percentage}\n{grade}");
        }
    }

    internal class Que09
    {
        Result[] result;
        int n;
        void addDetails()
        {
            Console.WriteLine("How many students details you want to add : ");
            n = Convert.ToInt32(Console.ReadLine());

            result = new Result[n];

            for (int i = 0; i < n; i++)
            {
                result[i] = new Result();
                result[i].addStudent();
            }

        }
        void displayResult()
        {
            for (int i = 0; i < n; i++)
            {
                result[i].showResult();
            }
        }
        internal void menu()
        {
            addDetails();
            displayResult();
        }
    }
}
