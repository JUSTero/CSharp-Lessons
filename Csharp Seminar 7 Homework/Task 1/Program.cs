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
            Console.WriteLine("Enter the number of lines");
            int lines = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the number of columns");
            int columns = Convert.ToInt32(Console.ReadLine());
            Random random = new Random();
            double[,] numbers = new double[columns, columns];
            Console.WriteLine("Created array:");

            for (int i = 0; i < lines; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    numbers[i, j] = random.NextDouble();
                    Console.Write($"{Math.Round(numbers[i, j], 2), 6}");
                }

                Console.WriteLine();
            }
        }
    }
}
