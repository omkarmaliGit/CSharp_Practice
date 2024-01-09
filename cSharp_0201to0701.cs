using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* Printing Hello world Program */
            Console.WriteLine("Hello World");

            /* Enter Name And Print It */
            Console.Write("Enter your Name : ");
            string name = Console.ReadLine();
            Console.WriteLine("Your Name is " + name);

            /* Addition of Two Numbers */
            int a, b, sum;
            //a = 12;
            //b = 13;

            //Console.WriteLine("Enter Two Numbers : ");
            a = Convert.ToInt32(Console.ReadLine());
            b = Convert.ToInt32(Console.ReadLine());
            sum = a + b;

            Console.WriteLine("Sum = " + sum);
            Console.WriteLine($"Sum = {sum}");
            Console.WriteLine("Sum = " + a + b);
            Console.WriteLine("Sum = " + (a + b));

            /* DataTypes */
            int ai = 12;

            /* Size and Range of every Data type */
            Console.WriteLine($"Size of Int = {sizeof(int)} & min Value is {int.MinValue} && max Value is {int.MaxValue}");
            Console.WriteLine($"Size of Int = {sizeof(int)} & min Value is {int.MinValue} && max Value is {int.MaxValue}");
            Console.WriteLine($"Size of Int64 = {sizeof(Int64)} & min Value is {Int64.MinValue} && max Value is {Int64.MaxValue}");
            Console.WriteLine($"Size of Int = {sizeof(long)} & min Value is {long.MinValue} && max Value is {long.MaxValue}");

            long int ali = 65;

            /* 05/01/24 */

            int x;
            Demo obj1 = new Demo(); //Object
            obj1.input();
            obj1.show();

            Console.Out.WriteLine(addition(2, 3));

            Console.ReadLine();
        }

        static int addition(int a, int b)
        {
            return a + b;
        }
    }



}