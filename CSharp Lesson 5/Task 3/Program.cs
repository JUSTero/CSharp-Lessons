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
            int[] numbers = new int[100];
            Random random = new Random();
            Console.WriteLine("Enter the desired number from -10 to 10");
            int desired = Convert.ToInt32(Console.ReadLine());
            Console.Write("Array created => ");
            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = random.Next(-10, 11);
                Console.Write($"{numbers[i],5}");
            }

            Console.WriteLine();

            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] == desired)
                {
                    Console.WriteLine("Searched number found");
                    break;
                }

                else if (i == numbers.Length - 1)
                {
                    Console.WriteLine("Searched number not found");
                }
            }
        }
    }
}
