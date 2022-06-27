using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prime
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n, i;
            int countt = 0;

            Console.WriteLine("Enter a positive number: ");
            n = int.Parse(Console.ReadLine());
            if (n >= 1)
            {
                for (i = 1; i <= n; i++)
                {

                    if (n % i == 0)
                    {
                        countt++;
                    }
                }
                if (n == 1)
                {
                    Console.WriteLine("1 is neither prime nor composite");
                }
                else if (countt > 2)
                    Console.WriteLine("It is Composite Number");
                else
                    Console.WriteLine("It is a prime Number");
            }
            else
                Console.WriteLine("Please enter a positive number");
        }
    }
}
