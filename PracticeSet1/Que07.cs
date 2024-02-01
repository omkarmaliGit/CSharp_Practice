using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeQuetions1
{
    //7. Design a base class person (name, address, phone_no). Derive a class employee(e_no, ename) from person. Derive a class manager (designation, department, basic_salary) from employee.  Write a menu driven program to accept all details of ‘n’ manager.  Display manager having highest salary.

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

    internal class Que07
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
}
