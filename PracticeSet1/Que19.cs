using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeQuetions1
{
    /* 19. Accept ‘n’ integers from the user and store them in a collection. Display them in the sorted order. The collection should not accept duplicate elements. (Use a suitable collection). Search for a particular element using predefined search method in the Collection. */

    class suitableCollection
    {
        public HashSet<int> collection = new HashSet<int>();
        int size;

        internal void acceptInteger()
        {
            Console.Write("How much integers you want? : ");
            size = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("\nEnter value");
            for (int i = 0; i < size; i++)
            {
                Console.Write($"for index {i + 1} : ");
                int num = Convert.ToInt32(Console.ReadLine());
                collection.Add(num);
            }

        }

        internal void display()
        {
            List<int> list = new List<int>();
            list = collection.ToList();

            list.Sort();

            Console.WriteLine();
            foreach (var item in list)
            {
                Console.WriteLine(item + " ");
            }
        }
    }

    internal class Que19
    {
        internal void start()
        {
            suitableCollection sc = new suitableCollection();
            sc.acceptInteger();
            sc.display();
        }
    }
}
