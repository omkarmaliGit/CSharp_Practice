using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeQuetions1
{
    /* 2.Write a program to accept a string from the user and perform the operations on it as per the following menu.
         a.Print reverse of the string
         b.Find length of the string.
         c.Print alternate character of the string.*/
    internal class Que02
    {
        string str;

        internal void accept()
        {
            Console.Write("Enter String : ");
            str = Console.ReadLine();

            reverse();
            length();
            alternate();
        }

        void reverse()
        {
            char[] charStr = str.ToCharArray();
            string revStr = "";

            for (int i = charStr.Length - 1; i >= 0; i--)
            {
                revStr += charStr[i];
            }

            Console.Write($"Reverse String : {revStr}");
        }

        void length()
        {
            char[] charStr = str.ToCharArray();
            Console.WriteLine($"\nLength of String : {charStr.Length}");
        }

        void alternate()
        {
            char[] charStr = str.ToCharArray();

            Console.Write("Alternative Characters of String : ");
            for (int i = 0; i < charStr.Length; i += 2)
            {
                Console.Write(charStr[i] + " ");
            }
        }
    }
}
