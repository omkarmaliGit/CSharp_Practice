using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeQuetions1
{
    //1.Write a C# program to determine the addition of two matrices.
    internal class Que01
    {
        int[,] arr1 = new int[10, 10];
        int[,] arr2 = new int[10, 10];
        int[,] arr3 = new int[10, 10];
        int n;

        internal void input()
        {
            Console.Write("Enter size of matrix : ");
            n = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine();

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write($"Enter value for matrix1 [{i},{j}] : ");
                    arr1[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }

            Console.WriteLine();

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write($"Enter value for matrix2 [{i},{j}] : ");
                    arr2[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }

            addition();
        }

        void addition()
        {
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    arr3[i, j] = arr1[i, j] + arr2[i, j];
                }
            }

            display();
        }

        void display()
        {
            Console.WriteLine("\nMatrix 3 after addition --> \n");

            for (int i = 0; i < n; i++)
            {
                Console.Write("|");
                for (int j = 0; j < n; j++)
                {
                    Console.Write($" {arr3[i, j]} |");
                }
                Console.WriteLine();
            }
        }
    }
}
