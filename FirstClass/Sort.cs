using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstClass
{
    internal class Sort
    {
        static void Main(string[] args)
        {
            int[] x = new int[5] { 10, 2, 30,9,50};

            for(int i=0; i<x.Length-1; i++)
            {
                for (int j = i + 1; j < x.Length; j++)
                {
                    if (x[i] > x[j])
                    {
                        int temp = x[i];
                        x[i] = x[j];
                        x[j] = temp;
                    }
                }
                
            }
            for (int i = 0; i < x.Length; i++)
            {
                Console.WriteLine(x[i]);
            }
            Console.ReadLine();

        }
    }
}
