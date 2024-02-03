using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeQuetions1
{
    /* 11. Write a program to define a class item (item_code, name, price & quantity). Define default & parameterized constructors. Accept details from the user. Calculate total price of all items & display details of item entered by user as well as sort all the items on the basis of cost. */

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
                Console.Write($"\n -- enter Item {i + 1} details -- ");
                Console.Write("\nItem Code : ");
                int item_code = Convert.ToInt32(Console.ReadLine());
                Console.Write("Name : ");
                string name = Console.ReadLine();
                Console.Write("Price : ");
                int price = Convert.ToInt32(Console.ReadLine());
                Console.Write("Quantity : ");
                int quantity = Convert.ToInt32(Console.ReadLine());

                item[i] = new Item(item_code, name, price, quantity);
            }
        }

        internal void sorting()
        {
            Item tempItem = new Item();

            for (int i = 0; i < size; i++)
            {
                for (int j = i + 1; j < size; j++)
                {
                    if (item[i].price > item[j].price)
                    {
                        tempItem = item[i];
                        item[i] = item[j];
                        item[j] = tempItem;
                    }
                }
            }
        }

        internal void displayDetails()
        {
            int totalPrice = 0;

            foreach (var it in item)
            {
                totalPrice += (it.price * it.quantity);
            }
            Console.WriteLine($"\nTotal price of all item : {totalPrice}");

            Console.WriteLine("\nBefore sorting --> ");
            foreach (var it in item)
            {
                Console.WriteLine(it.item_code + " " + it.name + " " + it.price + " " + it.quantity);
            }

            sorting();

            Console.WriteLine("\nAfter sorting --> ");
            foreach (var it in item)
            {
                Console.WriteLine(it.item_code + " " + it.name + " " + it.price + " " + it.quantity);
            }

        }

        internal void menu()
        {
            acceptDetails();
            displayDetails();
        }

    }
}
