using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstClass
{
    public class Addition
    {
        public int x, y, z;
        static void Main(string[] args)
        {
            Addition t = new Addition();
            t.Getdata();
            t.Add();
            t.Display();
            Console.ReadLine();

        }
        public void Getdata()
        {
            Console.WriteLine("Enter x value");
            x=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter y value");
            y=Convert.ToInt32(Console.ReadLine());
        }
        public void Add() 
        {
          z= x+y;
        }
        public void Display()
        {
            Console.WriteLine("Total is " + z);
        }

    }
}
