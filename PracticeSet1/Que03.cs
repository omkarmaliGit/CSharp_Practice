using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeQuetions1
{
    /* 3.Write a console application that places double quotation marks around each word in a string. */

    internal class Que03
    {
        string str;
        internal void doubleQuotation()
        {
            Console.Write("Enter string : ");
            str = Console.ReadLine();

            string quotedStr = "\"";

            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] == ' ')
                {
                    quotedStr += "\"" + str[i] + "\"";
                }
                else
                {
                    quotedStr += str[i];
                }
            }
            quotedStr += "\"";

            Console.WriteLine($"Double Quoted String : {quotedStr}");

        }
    }
}
