using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeQuetions1
{
    /*11.	Write a program to define a class item (item_code, name, price & quantity). Define default & parameterized constructors. Accept details from the user. Calculate total price of all items & display details of item entered by user as well as sort all the items on the basis of cost.*/

    class Item
    {
        internal int item_code;
        internal string name;
        internal int price;
        internal int quantity;

        internal Item() { }
        internal Item(int item_code, string name, int price, int quantity)
        {
            this.item_code = item_code;
            this.name = name;
            this.price = price;
            this.quantity = quantity;
        }


    }

    internal class Que11
    {
        Item[] item;
        int size;
        internal void acceptDetails()
        {
            Console.Write("How Many Items you want to enter : ");
            size = Convert.ToInt32(Console.ReadLine());

            item = new Item[size];

            for (int i = 0; i < size; i++)
            {
                Console.Write($"\n -- enter Item {i+1} details -- ");
                Console.Write("Item Code : ");
                int item_code = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Name : ");
                string name = Console.ReadLine();
                Console.WriteLine("Price : ");
                int price = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Quantity : ");
                int quantity = Convert.ToInt32(Console.ReadLine());

                item[i] = new Item(item_code, name, price, quantity);
            }
        }

        internal void displayDetails()
        {
            int totalPrice;

            Console.WriteLine("Before sorting --> ");
            foreach (var it in item)
            {
                Console.WriteLine(it.item_code +  " " + it.name + " " + it.price + " " + it.quantity);
            }



            //item.Sort((item1, item2) => item1.price.CompareTo(item2.price)); 

        }

    }
}
