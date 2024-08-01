using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstClass
{
    public class Array
    {
        static void Main(string[] args)
        {
            int[] A = new int[5] { 10, 11, 12, 13, 14 };
            Console.WriteLine("Elements of array are :");
            for (int i = 0; i < 5; i++)
            {
                Console.Write(A[i] + " ");
            }
            Console.ReadLine();
        }
    }
}