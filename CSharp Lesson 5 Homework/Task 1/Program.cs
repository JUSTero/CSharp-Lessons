using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter array lenght");
            int lenght = Convert.ToInt32(Console.ReadLine());
            Random random = new Random();
            int[] numbers = new int[lenght];
            int count = 0;
            Console.WriteLine("Create array:");
            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = random.Next(100, 1000);
                Console.Write($"{numbers[i], 5}");

                if (numbers[i] % 2 == 0)
                {
                    count++;
                }
            }

            Console.WriteLine();
            Console.WriteLine("Number of even numbers = " + count);
        }
    }
}
