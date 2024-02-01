using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeQuetions1
{
    /* 14. Define a class MyDate (day, month, year) with methods to accept and display a MyDate object. Accept date as dd, mm, yyyy. Throw user defined exception “InvalidDateException” if the date is invalid. 
        Examples of invalid dates : 1 15 2018, 31 9 2000, 29 2 2001
    */

    class InvalidDateException : Exception
    {
        internal InvalidDateException() { }

        internal InvalidDateException(string message) : base(message) { }
    }


    class MyDate
    {
        int day;
        int month;
        int year;

        internal void Accept()
        {
            Console.Write("Enter Date (dd mm yyyy): ");
            string[] date = Console.ReadLine().Split(' ');

            if (date.Length != 3 || !int.TryParse(date[0], out day) || !int.TryParse(date[1], out month) || !int.TryParse(date[2], out year))
            {
                throw new InvalidDateException("Invalid Date Format.");
            }

            if (!isValidDate())
            {
                throw new InvalidDateException("Invalid Date.");
            }
        }

        internal void Display()
        {
            Console.WriteLine($"Date: {day:D2}/{month:D2}/{year:D4}");
        }


        bool isValidDate()
        {
            if (month < 1 || month > 12 || day < 1) { return false; }

            int[] daysInMonth = { 0, 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };

            if (month == 2 && isLeapYear())
            {
                daysInMonth[2] = 29;
            }

            return day <= daysInMonth[month];

        }

        bool isLeapYear()
        {
            if ((year % 4 == 0 && year % 100 != 0) || year % 400 == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }

    internal class Que14
    {
        MyDate md = new MyDate();

        internal void dateValidater()
        {
            try
            {
                md.Accept();
                md.Display();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
