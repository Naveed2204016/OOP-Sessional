using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Services;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace Lab_4
{
    class Employee
    {
        private double salary;
        private string name;
        private string position;
        public Employee(double salary, string name, string position)
        {
            this.salary = salary;
            this.name = name;
            this.position = position;
        }

        protected double Salary
        {
            get { return salary; }
            set { salary = value; }
        }

        public void details()
        {
            Console.WriteLine("Name: " + name + " Position: " + position + " Salary:" + salary);
        }
    }

    class Manager : Employee
    {
        public Manager(double s, string n, string pos) : base(s, n, pos)
        {

        }

        public void update(double salary)
        {
            Salary = salary;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number of employees");
            int num;
            num = int.Parse(Console.ReadLine());
            Manager[] emp = new Manager[num];
            for (int i = 0; i < num; i++)
            {
                string name, pos;
                double salary;
                Console.WriteLine("Enter details for employee " + (i + 1));
                Console.WriteLine("Enter name");
                name = Console.ReadLine();
                Console.WriteLine("Enter psoition");
                pos = Console.ReadLine();
                Console.WriteLine("Enter salary");
                salary = double.Parse(Console.ReadLine());
                emp[i] = new Manager(salary, name, pos);
            }

            Console.WriteLine("Current employee details");
            for (int i = 0; i < num; i++)
            {
                Console.Write("Employee " + (i + 1) + " : ");
                emp[i].details();
                Console.WriteLine();
            }

            Console.WriteLine("For how many employees do you want to update salaries?");
            int x;
            x = int.Parse(Console.ReadLine());
            for (int i = 0; i < x; i++)
            {
                int x1;
                double ans;
                Console.WriteLine("Enter the employee number to update ");
                x1 = int.Parse(Console.ReadLine());
                if (x1 == -1)
                    break;
                Console.WriteLine("Enter the new salary");
                ans = double.Parse(Console.ReadLine());
                emp[x1 - 1].update(ans);
            }

            Console.WriteLine("Updated Employee details: ");
            for (int i = 0; i < emp.Length; i++)
            {
                Console.Write("Employee " + (i + 1) + " : ");
                emp[i].details();
                Console.WriteLine();
            }
            Console.ReadLine();
        }
    }
}
