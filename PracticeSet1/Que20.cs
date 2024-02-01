using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeQuetions1
{
    /* 20.	Write a program to accept a number from the user and throw an exception if the number is not an even number. */

    public class NotEvenNumberException : Exception
    {
        public NotEvenNumberException() { }
        public NotEvenNumberException(string message) : base(message) { }
    }

    internal class Que20
    {
        int number;
        void acceptNumber()
        {
            Console.Write("Enter Even Number : ");
            number = Convert.ToInt32(Console.ReadLine());
            if (number % 2 != 0)
            {
                throw new NotEvenNumberException("Number is not Even. Please enter Even number");
            }
            else
            {
                Console.WriteLine("Even Number");
            }
        }

        internal void tryThis()
        {
            try
            {
                acceptNumber();
            }
            catch (Exception e)
            {
                Console.WriteLine($"Exception : {e.Message}");
            }
        }

    }
}
