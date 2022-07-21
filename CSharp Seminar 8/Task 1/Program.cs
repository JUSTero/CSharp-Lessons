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
            Console.WriteLine("Enter the numbers of lines");
            int lines = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the numbers of columns");
            int columns = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter lower limit");
            int lowerLimit = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter upper limit");
            int upperLimit = Convert.ToInt32(Console.ReadLine());
            Random random = new Random();
            int[,] numbers = new int[lines, columns];

            void PrintArray()
            {
                for (int i = 0; i < lines; i++)
                {
                    for (int j = 0; j < columns; j++)
                    {
                        Console.Write(numbers[i, j] + " ");
                    }

                    Console.WriteLine();
                }
            }

            Console.WriteLine("Created array:");

            for (int i = 0; i < lines; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    numbers[i, j] = random.Next(lowerLimit, upperLimit + 1);
                }
            }

            PrintArray();

            Console.WriteLine();
            Console.WriteLine("Finished array:");

            int index = 0;

            for (int j = 0; j < columns; j++)
            {
                int temp = numbers[index, j];
                numbers[index, j] = numbers[numbers.GetLength(0) - 1, j];
                numbers[numbers.GetLength(0) - 1, j] = temp;
            }

            PrintArray();
            Console.WriteLine();

        }
    }
}
