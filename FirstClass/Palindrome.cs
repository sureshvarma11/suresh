using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstClass
{
    public class Palindrome
    {
        public static void Main(string[] args)
        {
            int n, r, sum = 0, t;
            Console.WriteLine("Enter a number");
            n=Convert.ToInt32(Console.ReadLine());
            t = n;
            while(n>0)
            {
                r = n % 10;
                sum = (sum * 10) + r;
                n= n / 10;
            }
            if(t==sum)
            {
                Console.WriteLine("Number is palindrome");
            }
            else
            {
                Console.WriteLine("Number is not palindrome");
            }
            Console.ReadLine();
        }
    }
}
