using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number");
            int number = Convert.ToInt32(Console.ReadLine());
            int sum = 0;

            int SumOfNumbers(int n)
            {
                if (n / 10 > 0)
                {
                    sum += n % 10;
                    SumOfNumbers(n / 10);
                }

                else
                {
                    sum += n;
                }

                return sum;
            }

            SumOfNumbers(number);
            Console.WriteLine($"Sum of digits = {sum}");
        }
    }
}
    
