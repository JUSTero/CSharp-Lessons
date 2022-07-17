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
            Console.WriteLine("Enter the number of lines");
            int lines = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the number of columns");
            int columns = Convert.ToInt32(Console.ReadLine());
            int[,] numbers = new int[lines, columns];

            for (int i = 0; i < numbers.GetLength(0); i++)
            {
                for (int j = 0; j < numbers.GetLength(0); j++)
                {
                    numbers[i, j] = i + j;
                    Console.Write($"{numbers[i, j],5}");
                }

                Console.WriteLine();
            }
        }
    }
}
