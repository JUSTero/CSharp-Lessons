using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter count of numbers");
            int num = Convert.ToInt32(Console.ReadLine());
            int[] numbers = new int[num];
            Console.WriteLine("Fibonacci sequence:");

            if (num == 2)
            {
                Console.Write($"0  1");
                Console.WriteLine();
            }

            else if (num == 1)
            {
                Console.Write("0");
                Console.WriteLine();
            }

            else if (num > 2)
            {
                Console.Write($"0  1 ");
                numbers[1] = 1;
                for (int i = 2; i < num; i++)
                {
                    numbers[i] = numbers[i - 2] + numbers[i - 1];
                    Console.Write($" {numbers[i]} ");
                }
                Console.WriteLine();
            }
        }
    }
}
