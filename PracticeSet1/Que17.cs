using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeQuetions1
{
    /* 17.	Write a program to create a class Login. Accept user name & password from the user. Throw user defined exception” invalidPassword” if the length of password is less than 8 characters. If the user name and password are same then display the message “Login Successful” otherwise throw an exception “Invalid Login”. */

    class InvalidPassword : Exception
    {
        internal InvalidPassword() { }
        internal InvalidPassword(string msg) : base(msg) { }
    }

    class InvalidLogin : Exception
    {
        internal InvalidLogin() { }
        internal InvalidLogin(string msg) : base(msg) { }
    }

    class Login
    {
        string username = "";
        string password = "";

        internal void login()
        {
            do
            {
                Console.Write("Enter UserName : ");
                username = Console.ReadLine();
                Console.Write("Enter Password : ");
                password = Console.ReadLine();

                Console.WriteLine();

                try {

                    if (password.Length < 8)
                    {
                        throw new InvalidPassword("length of password is less than 8 characters please enter correct password\nplease try again --> \n");
                    }
                    else
                    {
                        if (password != username)
                        {
                            throw new InvalidLogin("username and password are not matching Login Failed\nplease try again --> \n");
                        }
                        else
                        {
                            Console.WriteLine("Login Successful");
                        }
                    }

                } catch (Exception e) {  Console.WriteLine(e.Message); }

            } while (password.Length < 8 || username != password);
        }
    }


    internal class Que17
    {
        Login l = new Login();

        internal void loginCheck()
        {
            //try
            //{
                l.login();
            //}
            //catch(Exception e)
            //{
            //    Console.WriteLine(e.Message);
            //}
        }

    }
}
