using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeQuetions1
{
    /* 10. Create a class TestArrayList having main method.       Perform following functionality:
        a.	Create an ArrayList having Product name of type    String.
        b.	Store different product names. Try to add          duplicate product names.
        c.	Print all product names.
        d.	Print the first and last product names.
        e.	Print the size of ArrayList.
        f.	Remove a particular product from ArrayList.
        g.	Again verify the size of ArrayList.
    */

    class TestArrayList
    {
        ArrayList productName = new ArrayList();
        
        internal void storeProductName()
        {
            productName.Add("Product1");
            productName.Add("Product2");
            productName.Add("Product2");
            productName.Add("Product3");
            productName.Add("Product5");
        }

        internal void printAll()
        {
            Console.Write("All Products --> ");
            foreach (var item in productName)
            {
                Console.Write(item + " ");
            }
        }

        internal void printFirstLast()
        {
            Console.WriteLine($"\nFirst Product --> {productName[0]}");
            Console.WriteLine($"Last Product --> {productName[productName.Count - 1]}");
        }

        internal void sizeOfList()
        {
            Console.WriteLine(productName.Count);
        }

        internal void removeProduct(string n)
        {
            productName.Remove(n);
            Console.WriteLine("Product Removed Successfully");
            //sizeOfList();
            productName.RemoveAt(3);

        }
    }
    internal class Que10
    {
        TestArrayList t = new TestArrayList();
        internal void runProgram()
        {
            t.storeProductName();
            t.printAll();
            t.printFirstLast();
            t.sizeOfList();
            t.removeProduct("Product2");
            t.sizeOfList();
        }

    }
}
