using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstClass
{
    internal class ClsEmployee
    {
        class Employee
        {
            int id;
            string name;
            string address;
            string salary;

            public void Getdata()
            {
                Console.WriteLine("Enter Employee Details :");
                this.id=Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter Employee Name :");
                this.name=Console.ReadLine();
                Console.WriteLine("Enter Employee Address :");
                this.address=Console.ReadLine();
                Console.WriteLine("Enter Employee salary :");
                this.salary=Console.ReadLine();
            }
            public void Display()
            {
                Console.WriteLine("Employee Details");
                Console.WriteLine("Emp Id is:" + this.id);
                Console.WriteLine("Emp Name is:" + this.name);
                Console.WriteLine("Emp Address is:" + this.address);
                Console.WriteLine("Emp Salary is:" + this.salary);
            }
        }
        class Encapsulate
        {
            static void Main(string[] args)
            {
                Employee emp = new Employee();
                emp.Getdata();
                emp.Display();
                Console.Read();
            }
        }
    }
}
