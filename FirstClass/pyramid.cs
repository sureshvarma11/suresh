using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstClass
{
    internal class pyramid
    {
        static void Main(string[] args)
        {
            string example = "";
            Console.Write("Enter a string :");
            example = Console.ReadLine();
            int l = example.Length / 2, t = 0;

            for (int i = 0; i <= example.Length / 2; i++)
            {
                t = l;
                for (int j = 0; j <= example.Length - i - 1; j++)
                {
                    Console.Write(" ");
                }
                for (int k = 0; k <= i * 2; k++)
                {
                    if (l < 0)
                    {
                        break;
                    }
                    Console.Write(example[l]);
                    l++;
                }
                t--;
                l = t;
                Console.WriteLine();
            }
            Console.Read();
        }
    }
    
}
