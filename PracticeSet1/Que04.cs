using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeQuetions1
{
    /* 4.Write an application that receives the following information from a set of     students:
       a.	Student Id:
       b.	Student Name:
       c.	Course Name:
       d.	Date of Birth:
      The application should also display the information of all the students once the data is Entered. Implement this using an Array of Structures.
   */
    struct Student
    {
        internal int studentId;
        internal string studentName;
        internal string courseName;
        internal DateTime dateofBirth;
    };

    internal class Que04
    {
        Student[] stu;
        int size;

        internal void receiveInfo()
        {
            Console.Write("How many students information you want to enter : ");
            size = Convert.ToInt32(Console.ReadLine());

            stu = new Student[size];

            for (int i = 0; i < size; i++)
            {
                Console.Write($"\nEnter student {i + 1} Id : ");
                stu[i].studentId = Convert.ToInt32(Console.ReadLine());
                Console.Write($"Enter student {i + 1} Name : ");
                stu[i].studentName = Console.ReadLine();
                Console.Write($"Enter student {i + 1} Course Name : ");
                stu[i].courseName = Console.ReadLine();
                Console.Write($"Enter student {i + 1} Date of Birth : ");
                stu[i].dateofBirth = Convert.ToDateTime(Console.ReadLine());
            }

            displayInfo();

        }

        void displayInfo()
        {
            Console.WriteLine("\n<-- Displaying Student Information -->");

            for (int i = 0; i < size; i++)
            {
                Console.WriteLine($"\nstudent {i + 1} Id : {stu[i].studentId}");
                Console.WriteLine($"student {i + 1} Name : {stu[i].studentName}");
                Console.WriteLine($"student {i + 1} Course Name : {stu[i].courseName}");
                Console.WriteLine($"student {i + 1} Date of Birth : {stu[i].dateofBirth}");
            }
        }
    }
}
