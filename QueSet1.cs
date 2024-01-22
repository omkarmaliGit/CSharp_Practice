using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

using System.Text.RegularExpressions;
using System.Collections;

namespace ConsoleApp1
{
    //13-01-2024

    /* Q1. Create base class called shape. Use this class to store two double type 
     * values that could be used to compute the area of figures. 
     * Derive three specific classes called triangle, circle and rectangle from 
     * the base shape. Add to the base class, a member function GetData() 
     * to initialize base class data members and DisplayArea() to compute 
     * and display area. Make DisplayArea() as an abstract method. */

    abstract class shape
    {
        protected double length;
        protected double width;

        protected internal void getData(int a, int b)
        {
            length = a;
            width = b;
        }

        protected internal abstract void displayArea();
    }

    class triangle : shape
    {
        double triangleArea;
        protected internal override void displayArea()
        {
            triangleArea = 0.5 * length * width;
            Console.WriteLine("Triangle Area : " + triangleArea);
        }
    }

    class circle : shape
    {
        double circleArea;
        protected internal override void displayArea()
        {
            circleArea = (3.14) * (length * length);
            Console.WriteLine("Circle Area : " + circleArea);
        }
    }

    class rectangle : shape
    {
        double rectangleArea;
        protected internal override void displayArea()
        {
            rectangleArea = length * width;
            Console.WriteLine("Rectangle Area : " + rectangleArea);
        }
    }

    /* Q2. Write a program in c# to read the following infromation from the 
     * keyboard in which the base class consists of employee name, code 
     * and designation. the derived class Manager which contains the data members 
     * namely, year of experience and salary. Display the whole infromation on 
     * the screen. */

    class Employee
    {
        protected string name;
        protected int code;
        protected string designation;

        protected Employee(string name, int code, string designation)
        {
            this.name = name;
            this.code = code;
            this.designation = designation;
        }
    }

    class Manager : Employee
    {
        protected internal string name;
        protected internal int experience;
        protected internal float salary;

        public Manager(string name, int code, string designation, int experience, float salary) : base(name, code, designation)
        {
            this.name = name;
            this.experience = experience;
            this.salary = salary;
        }

        internal void displayInfo()
        {
            Console.WriteLine($"\n\n'Employee Information'" +
                $"\nName : {name}" +
                $"\nCode : {code}" +
                $"\nDesignation : {designation}" +
                $"\nYear of Experience : {experience}" +
                $"\nSalary : {salary}");

        }
    }

    /* Q3. Design a base class person(name, address, phone no.). 
     * Derive a class employee(e_no, ename) from person.
     * Derive a class manager(designation, department, basic_salary) from employee.
     * Write a menudriven program to accept all details of 'n' manager.
     * Display manager having highest salary.
     */

    class person
    {
        internal string name;
        string address;
        long phone;

        protected person(string name, string address, long phone)
        {
            this.name = name;
            this.address = address;
            this.phone = phone;
        }
    }

    class employee : person
    {
        int empNo;
        string empName;

        protected employee(int empNo, string empName, string address, long phone) : base(empName, address, phone)
        {
            this.empNo = empNo;
            this.empName = empName;
        }
    }

    class manager : employee
    {
        string designation;
        string department;
        internal int salary;

        internal manager(string designation, string department, int salary, int empNo, string empName, string address, long phone) : base(empNo, empName, address, phone)
        {
            this.designation = designation;
            this.department = department;
            this.salary = salary;
        }

    }

    class Menu
    {
        manager[] m = new manager[20];
        int n;

        internal void menu()
        {
            int choice;
            do
            {
                Console.WriteLine("\n -- Enter your choice -- \n" +
                    "1 : To enter manager details \n" +
                    "2 : To display manager with highest salary \n" +
                    "3 : To EXIT");
                choice = Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        enterDetails();
                        break;
                    case 2:
                        displayManager();
                        break;
                    case 3:
                        break;

                    default:
                        Console.WriteLine("enter valid choice!");
                        break;
                }
            } while (choice != 3);

        }

        void enterDetails()
        {
            Console.Write("\nHow many manager you want to enter : ");
            n = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("\nenter Name : ");
                string empName = Console.ReadLine();
                Console.WriteLine("enter Phone Number : ");
                long phone = Convert.ToInt64(Console.ReadLine());
                Console.WriteLine("enter Address : ");
                string address = Console.ReadLine();
                Console.WriteLine("enter Employee Number : ");
                int empNo = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("enter Designation : ");
                string designation = Console.ReadLine();
                Console.WriteLine("enter Department : ");
                string department = Console.ReadLine();
                Console.WriteLine("enter Salary : ");
                int salary = Convert.ToInt32(Console.ReadLine());

                m[i] = new manager(designation, department, salary, empNo, empName, address, phone);
            }

            Console.WriteLine("\n All entries done successfully!");
        }
        void displayManager()
        {
            int greatestSal = 0;

            for (int i = 0; i < n; i++)
            {
                if (greatestSal < m[i].salary)
                {
                    greatestSal = m[i].salary;
                }
            }

            for (int i = 0; i < n; i++)
            {
                if (greatestSal == m[i].salary)
                {
                    Console.WriteLine($"\nMANAGER DETAIL who has highest salary : and this is number {i + 1} index number\n" +
                        $"name : {m[i].name} , with salary of {m[i].salary}");
                }
            }
        }
    }


    //20-01-2024

    /* Q4. Define a class validate_email which will validate email address.
     * Accept the address from the user.*/

    class emailException : Exception
    {
        internal emailException() { }
        internal emailException( string message ) : base(message)
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
            Regex regex = new Regex("^[a-z0-9][-a-z0-9._]+@([-a-z0-9]+.)+[a-z]{2,5}$");

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

    internal class Program
    {
        static void Main(string[] args)
        {
            /* Quetion 1 */

            shape s = new triangle();
            s.getData(5, 10);
            //s.displayArea();

            s = new circle();
            s.getData(5, 10);
            //s.displayArea();

            s = new rectangle();
            s.getData(5, 10);
            //s.displayArea();

            /* Quetion 2 */

            //Console.WriteLine("Enter Employee Details - ");
            //Console.Write("Name : ");
            //string name = Console.ReadLine();
            //Console.Write("Code : ");
            //int code = Convert.ToInt32(Console.ReadLine());
            //Console.Write("Designation : ");
            //string designation = Console.ReadLine();
            //Console.Write("Year of Experience : ");
            //int yofEx = Convert.ToInt32(Console.ReadLine());
            //Console.Write("Salary : ");
            //float salary = Convert.ToSingle(Console.ReadLine());

            //Manager m = new Manager(name, code, designation, yofEx, salary);
            //m.displayInfo();

            /* Quetion 3 */
            Menu m = new Menu();
            //m.menu();

            /* Quetion 4 */
            ValidateEmail ve = new ValidateEmail();
            ve.acceptAddress();




            Console.ReadKey();
        }
    }
}
