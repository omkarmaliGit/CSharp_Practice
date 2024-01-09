using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        /* 08/01/2024 */

        int inA;
        int inB;

        static int add(int a, int b)
        {
            return a + b;
        }

        static int add(int a, int b, int c)
        {
            return a + b + c;
        }

        int add(int a, int b, int c, int d)
        {
            return a + b + c + d;
        }

        static void UpdateWithValue(int v)
        {
            v = 30;
        }

        static void UpdateWithReference(ref int v)
        {
            v = 30;
        }

        static void UpdateWithObject(Program p)
        {
            p.inA = 1; p.inB = 2;
        }

        struct Person
        {
            public int id;
            public string name;
            public int age;
        };

        static void Main(string[] args)
        {

            //Function Overloading

            Console.WriteLine(add(2, 3));
            Console.WriteLine(add(2, 3, 4));

            Program p = new Program();
            Console.WriteLine(p.add(2, 3, 4, 5));

            //Call by Value
            int cv = 10;
            UpdateWithValue(cv);
            Console.WriteLine("Value -> " + cv);

            //Call by Reference
            //method 1
            int cr = 10;
            UpdateWithReference(ref cr);
            Console.WriteLine("Reference -> " + cr);

            //method 2 -> using object as a parameter

            Program CbyO = new Program();
            CbyO.inA = 10; CbyO.inB = 10;
            UpdateWithObject(CbyO);
            Console.WriteLine(CbyO.inA + " <--> " + CbyO.inB);

            //Arrays

            //array intialization
            int[] arr1 = new int[4];
            int[] arr2 = new int[4] { 1, 2, 3, 4 };
            int[] arr3 = new int[] { 10, 20, 30, 40, 50 };
            int[] arr4 = { 11, 22, 33, 44 };

            int[] arr = new int[4];
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = i + 12;
            }
            foreach (int i in arr)       //foreach loop
            {
                Console.WriteLine(i);
            }

            //array sort method
            string[] cars = { "volvo", "bmw", "ford", "mazda" };
            Array.Sort(cars);
            foreach (string s in cars)
            {
                Console.WriteLine(s);
            }

            //2D array
            int[,] twoDarr = { { 1, 2, 3, 4, 5, }, { 10, 20, 30, 40, 50 } };
            int[,] twoDarr2 = new int[2, 3];

            foreach (int item in twoDarr)
            {
                Console.Write(item);
            }

            //Structure

            Person om;
            om.id = 1;
            om.name = "Test";
            om.age = 35;

            Console.WriteLine(om.id + " " + om.name + " " + om.age);








            Console.ReadKey();
        }
    }
}