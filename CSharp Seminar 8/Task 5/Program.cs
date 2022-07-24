using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number of lines");
            int n = Convert.ToInt32(Console.ReadLine());

            int factorial(int m)
            {
                int x = 1;

                for (int i = 1; i <= m; i++)
                {
                    x *= i;
                }

                return x;
            }

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j <= (n - i); j++)
                {
                    Console.Write(" ");
                }

                for (int k = 0; k <= i; k++)
                {
                    Console.Write(" ");
                    Console.Write(factorial(i) / (factorial(k) * factorial(i - k)));
                }

                Console.WriteLine();
                Console.WriteLine();
            }
        }
    }
}
