using System;
using System.Collections;
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
            protected float totalMarks;
            internal float addmarks()
            {
                for (int i = 0; i < 3; i++)
                {
                    Console.Write($"enter Subject {i + 1} Marks : ");
                    mark[i] = Convert.ToInt32(Console.ReadLine());
                    totalMarks += mark[i];
                }
                return totalMarks;
            }

            internal void displaymarks()
            {
                Console.Write("Student Marks : ");
                for (int i = 0; i < 3; i++)
                {
                    Console.Write($"\nSubject {i + 1} marks :  {mark[i]}");
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
            float totalM;
            Console.Write("\nenter RollNo. : ");
            roll_no = Convert.ToInt32(Console.ReadLine());
            Console.Write("enter Name : ");
            name = Console.ReadLine();
            mark = new Marks();
            totalM = mark.addmarks();
            percentage = totalM / 3;

            if (percentage >= 80.00) { grade = 'A'; }
            else if (percentage >= 60.00 && percentage < 80.00) { grade = 'B'; }
            else if (percentage >= 40.00 && percentage < 60.00) { grade = 'C'; }
            else { grade = 'F'; }
        }

        internal void showResult()
        {
            Console.WriteLine($"\nStudent RollNo : {roll_no}\nStudent Name : {name}");
            mark.displaymarks();
            Console.WriteLine($"\nStudent Percentage : {percentage}\nStudent Grade : {grade}");
        }
    }

    internal class Que09
    {
        Result[] result;
        int n;
        void addDetails()
        {
            Console.Write("How many students details you want to add : ");
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
            Result temp = new Result();

            for (int i = 0; i < n; i++)
            {
                for (int j = i + 1; j < n; j++)
                {
                    if (result[i].percentage < result[j].percentage)
                    {
                        temp = result[i];
                        result[i] = result[j];
                        result[j] = temp;
                    }

                }
            }

            Console.WriteLine("\n --> Displaying Result <-- ");

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
