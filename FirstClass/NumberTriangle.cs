using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstClass
{
    public class NumberTriangle
    {
        public static void Main(string[] args)
        {
            int i, j, k, l, n;
            Console.WriteLine("Enter number of range :");
            n=Convert.ToInt32(Console.ReadLine());
            j=n-1;

            for (i = 1; i <= n; i++)
            {
                for (j = 1; j <= n-i; j++)
                {
                    Console.Write(" ");
                }
                for (k = 1; k <= i; k++)
                {
                    Console.Write(k);
                }
                for (l = i - 1; l >= 1; l--)
                {
                    Console.Write(l);
                }
                Console.WriteLine();
            }
            Console.ReadLine();
        }
    }
}
