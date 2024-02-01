using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace PracticeQuetions1
{
    /* 15.	Define a class Validate_email which will validate email address. Accept the address from the user. 
Examples of invalid email address : 12cv@abc.com, A$#@abc.com, AS.abc.com etc.
 */
    class emailException : Exception
    {
        internal emailException() { }
        internal emailException(string message) : base(message)
        {

        }
    }

    class ValidateEmail
    {
        string email;

        internal void acceptAddress()
        {
            Console.Write("Enter your email address : ");
            try
            {
                email = Console.ReadLine();
                validateEmail(email);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

        }

        void validateEmail(string email)
        {
            Regex regex = new Regex("^[a-z][-a-z0-9._]+@([-a-z0-9]+.)+[a-z]{2,5}$");

            if (regex.IsMatch(email))
            {
                Console.WriteLine("Validated Successfully!");

            }
            else
            {
                Console.WriteLine("Failed!");
                throw new emailException("not a valid email. email exception envoked");
            }
        }

    }
    internal class Que15
    {
        ValidateEmail ve = new ValidateEmail();

        internal void email()
        {
            ve.acceptAddress();
        }
    }
}
