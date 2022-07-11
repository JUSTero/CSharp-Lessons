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
            Random random = new Random();
            int[] numbers = new int[123];
            Console.WriteLine("Create array:");
            int count = 0;

            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = random.Next(1001);
                Console.Write($"{numbers[i], 5}");
            }

            Console.WriteLine();
            Console.WriteLine();


            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] >= 10 && numbers[i] <= 99)
                {
                    count++;
                }
            }

            Console.WriteLine($"{count, 4} numbers satisfy the condition");
        }
    }
}
