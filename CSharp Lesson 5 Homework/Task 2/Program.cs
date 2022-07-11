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
            Console.WriteLine("Enter array lenght");
            int lenght = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter bottom limit");
            int botLim = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter top limit");
            int topLim = Convert.ToInt32(Console.ReadLine());
            Random random = new Random();
            int[] numbers = new int[lenght];
            int sum = 0;
            Console.WriteLine("Create array:");

            for (int i = 0; i < lenght; i++)
            {
                numbers[i] = random.Next(botLim, topLim);
                Console.Write($"{numbers[i], 5}");
            }

            Console.WriteLine();

            for (int i = 0; i < lenght; i += 2)
            {
                sum += numbers[i];
            }

            Console.WriteLine("Result: " + sum);
        }
    }
}
