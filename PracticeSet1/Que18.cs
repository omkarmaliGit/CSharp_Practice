using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeQuetions1
{
    /* 18.	Implement Hash table to store n records of Students (Name, Percentage). Write a menu driven program to:
a.	Add student
b.	Display details of all students
c.	Search student
d.	Find out highest marks.
 */

    class STUDent
    {
        Hashtable ht = new Hashtable();

        internal void addStudent()
        {
            ht.Add("carry", 43);
            ht.Add("harry", 94);
            ht.Add("mari", 56);
            ht.Add("sarika", 76);
            ht.Add("shreeman", 68);

        }

        internal void display()
        {
            foreach (DictionaryEntry item in ht)
            {
                Console.WriteLine($"Name : {item.Key} , Percentage : {item.Value}");
            }

        }

        internal void search(string name)
        {

            if(ht.ContainsKey(name))
            {
                Console.WriteLine($"{name} is Found");
            }
            else
            {
                Console.WriteLine($"{name} is Not Found");
            }

        }

        internal void findHighest()
        {
            int highestMark = 0;

            foreach (DictionaryEntry i in ht)
            {
                if (Convert.ToInt32(i.Value) > highestMark) {
                    highestMark = Convert.ToInt32(i.Value);
                }
            }

            Console.WriteLine($"Highest Mark --> {highestMark}");
        }

    }

    internal class Que18
    {
        STUDent s = new STUDent();
        internal void menu()
        {
            s.addStudent();
            s.display();
            s.search("omkar");
            s.findHighest();
        }

    }
}
