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
            Console.WriteLine("Enter array lenght");
            int lenght = Convert.ToInt32(Console.ReadLine());
            int[] numbers = new int[lenght];
            int[] result = new int[lenght];
            Random random = new Random();
            Console.WriteLine("Create array:");
            for (int i = 0; i < lenght; i++)
            {
                numbers[i] = random.Next(101);
                Console.Write($"{numbers[i], 3}");
            }

            Console.WriteLine();
            Console.WriteLine("Result:");
            int size = lenght - 1; 

            for (int i = 0; i < lenght / 2; i++)
            {
                result[i] = numbers[i] + numbers[size - i];
                Console.Write($"{result[i], 4}");
            }
            if (lenght % 2 != 0)
            {
                Console.Write($"{numbers[lenght / 2], 4}");
            }
            Console.WriteLine();
        }
    }
}
