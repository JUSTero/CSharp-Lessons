using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the lower number");
            int lowerNumber = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the upper number");
            int upperNumber = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();
            int sum = 0;

            if (upperNumber < lowerNumber)
            {
                int temp = lowerNumber;
                lowerNumber = upperNumber;
                upperNumber = temp;
            }

            int sumOfNumbers(int m, int n)
            {
                if (m <= n)
                {
                    sum += m;
                    sumOfNumbers(m + 1, n);
                }

                return sum;
            }

            sumOfNumbers(lowerNumber, upperNumber);
            Console.WriteLine($"Sum of numbers = {sum}");
            Console.WriteLine();
        }
    }
}
