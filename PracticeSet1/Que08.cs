using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeQuetions1
{
    /* 8. A company markets books audio tapes. Prepare a class publication having members (title, price). From this class derive two classes ‘Book’ which adds a page count, ‘Tape’ which adds a playing time in minutes. The program should contain following menu. Display all books.  Display all tapes.  All books having pages>n. All tapes having palying time>=n minutes. */

    class Publication
    {
        protected string title;
        protected int price;
    }
    class Book : Publication
    {
        int page_count;

        internal void add_book()
        {
            Console.Write("\nEnter Book Title : ");
            title = Console.ReadLine();
            Console.Write("Enter Book Price : ");
            price = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter Book Pages : ");
            page_count = Convert.ToInt32(Console.ReadLine());

        }

        internal void display_book()
        {
            Console.WriteLine($"Book Title : {title},\tBook Price : {price} Rs,\tBook Pages : {page_count}");
        }

        internal void filter_book(int count)
        {
            if (page_count > count)
            {
                display_book();
            }
        }
    }

    class Tape : Publication
    {
        int playing_time_in_min;

        internal void add_tape()
        {
            Console.Write("\nEnter Tape Title : ");
            title = Console.ReadLine();
            Console.Write("Enter Tape Price : ");
            price = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter Tape Pages : ");
            playing_time_in_min = Convert.ToInt32(Console.ReadLine());

        }

        internal void display_tape()
        {
            Console.WriteLine($"Tape Title : {title},\tTape Price : {price} Rs,\tTape Pages : {playing_time_in_min}");
        }

        internal void filter_tape(int count)
        {
            if (playing_time_in_min > count)
            {
                display_tape();
            }
        }
    }

    internal class Que08
    {
        Book[] book;
        Tape[] tape;
        int n;

        internal void addBook()
        {
            Console.Write("\nHow many book you want to add : ");
            n = Convert.ToInt32(Console.ReadLine());

            book = new Book[n];

            for (int i = 0; i < n; i++)
            {
                book[i] = new Book();
                book[i].add_book();
            }
        }

        internal void displayBook()
        {
            Console.WriteLine("\nDisplaying All Books --> ");
            for (int i = 0; i < n; i++)
            {
                book[i].display_book();
            }
        }

        internal void filterBook()
        {
            Console.Write("\nHow many pages book you want? : ");
            int pageN = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"\nDisplaying books which have pages more than {pageN} --> ");
            for (int i = 0; i < n; i++)
            {
                book[i].filter_book(pageN);
            }
        }

        internal void addTape()
        {
            Console.Write("\nHow many tape you want to add : ");
            n = Convert.ToInt32(Console.ReadLine());

            tape = new Tape[n];

            for (int i = 0; i < n; i++)
            {
                tape[i] = new Tape();
                tape[i].add_tape();
            }
        }

        internal void displayTape()
        {
            Console.WriteLine("\nDisplaying All Tapes --> ");
            for (int i = 0; i < n; i++)
            {
                tape[i].display_tape();
            }
        }

        internal void filterTape()
        {
            Console.Write("\nHow many pages tape you want? : ");
            int playTime = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"\nDisplaying tapes which have playtime more than {playTime} --> ");
            for (int i = 0; i < n; i++)
            {
                tape[i].filter_tape(playTime);
            }
        }

        internal void menu()
        {
            int choise;

            do
            {
                Console.Write("welcome to ABC publication\nwhat you want? 1.Book or 2.AudioBook/Tape. Enter 3.To Exit : ");
                choise = Convert.ToInt32(Console.ReadLine());

                switch (choise)
                {
                    case 1:
                        Console.Write("\nYou choose Book\nEnter 1.To Add Book, 2.To Display All Books, 3.To Filter Books By Number Of Pages : ");
                        int chB = Convert.ToInt32(Console.ReadLine());
                        switch (chB)
                        {
                            case 1: addBook(); break;
                            case 2: displayBook(); break;
                            case 3: filterBook(); break;
                        }

                        break;
                    case 2:
                        Console.Write("\nYou choose Tape\nEnter 1.To Add Tape, 2.To Display All Tapes, 3.To Filter Tapes By Playing Time : ");
                        int chT = Convert.ToInt32(Console.ReadLine());
                        switch (chT)
                        {
                            case 1: addTape(); break;
                            case 2: displayTape(); break;
                            case 3: filterTape(); break;
                        }

                        break;
                }
            } while (choise != 3);
        }
    }
}
