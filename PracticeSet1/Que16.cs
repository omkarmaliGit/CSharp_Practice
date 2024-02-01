using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeQuetions1
{
    /*
     16.	Write a program to create a class Movie (name, release_year, budget). Accept details of movies from the user. Throw user defined exception “invalid year” if the year is invalid as well as throw the exception invaidBudget if the user has entered other than digits.
     */

    class InvalidYear : Exception
    {
        internal InvalidYear() { }
        internal InvalidYear(string message) : base(message) { }
    }

    class InvalidBudget : Exception
    {
        internal InvalidBudget() { }
        internal InvalidBudget(string message) : base(message) { }
    }

    class Movie
    {
        string name;
        int releaseYear;
        string budgetStr;
        int budget;


        internal void acceptMovieDetails()
        {
            Console.Write("Enter movie name : ");
            name = Console.ReadLine();
            Console.Write("Enter movie release year : ");
            releaseYear = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter movie Budget in numbers only : ");
            budgetStr = Console.ReadLine();

            bool isNumber = int.TryParse(budgetStr, out budget);

            if (releaseYear < 2024)
            {
                throw new InvalidYear("Release Date Should be more than 2024");
            }
            else if (!isNumber)
            {
                throw new InvalidBudget("Only Numbers Allowed In Budget");
            }
            else
            {
                Console.WriteLine("Movie Added Successfully!");
            }
        }
    }

    internal class Que16
    {
        Movie m = new Movie();

        internal void movies()
        {
            try
            {
                m.acceptMovieDetails();
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

    }
}
