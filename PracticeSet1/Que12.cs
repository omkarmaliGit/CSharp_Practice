using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeQuetions1
{
    /* 12. Design an interface to write functions: sum(), avg(), max(), min(). Write a menu-driven program to implement this interface. */

    interface calculations
    {
        int Sum(int a, int b);
        int Avg(int a, int b);
        int Max(int a, int b);
        int Min(int a, int b);
    }

    internal class Que12 : calculations
    {
        int a, b;
        public int Sum(int a, int b) {
            return a+b; 
        }
        public int Avg(int a, int b) {
            return (a+b)/2;
        }
        public int Max(int a, int b) {
            return a>b?a:b;
        }
        public int Min(int a, int b) {
            return a<b?a:b;
        }

        internal void menu()
        {
            Console.WriteLine(" -- Enter Numbers for calculation -- ");
            Console.Write("Number 1 : ");
            a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Number 2 : ");
            b = Convert.ToInt32(Console.ReadLine());

            int choice;
            do
            {
            Console.Write("\n1.Sum, 2.Avg, 3.Max, 4.Min 5.Exit\nEnter your choice : ");
                choice = Convert.ToInt32(Console.ReadLine());

                switch(choice)
                {
                    case 1: Console.WriteLine("Sum --> "+Sum(a, b));  break;
                    case 2: Console.WriteLine("Avg --> " + Avg(a, b)); break;
                    case 3: Console.WriteLine("Max --> " + Max(a, b)); break;
                    case 4: Console.WriteLine("Min --> " + Min(a, b)); break;
                    case 5:
                        Console.WriteLine("Thank you for using App!");
                        break;
                }

            } while (choice != 5);

        }
    }
}
