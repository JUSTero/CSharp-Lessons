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
            void PrintArray(int[,] array, int m, int n)
            {
                for (int i = 0; i < m; i++)
                {
                    for (int j = 0; j < n; j++)
                    {
                        Console.Write($"{array[i, j],3}");
                    }

                    Console.WriteLine();
                }
            }
            int CreateArray(int[,] array, int m, int n)
            {
                for (int i = 0; i < m; i++)
                {
                    for (int j = 0; j < n; j++)
                    {
                        array[i, j] = random.Next(lowerLimit, upperLimit + 1);
                    }
                }

                return array[m - 1, n - 1];
            }

            CreateArray(numbers, lines, columns);
            Console.WriteLine("Created array:");
            PrintArray(numbers, lines, columns);

            int minLine = 0;
            int minLineSum = 0;

            for (int i = 0; i < lines; i++)
            {
                int sum = 0;
                for (int j = 0; j < columns; j++)
                {
                    sum += numbers[i, j];
                }

                Console.WriteLine();
                Console.WriteLine((i + 1) + " Line sum = " + sum);

                if (i == 0)
                {
                    minLineSum = sum;
                }

                if (sum <= minLineSum)
                {
                    minLineSum = sum;
                    minLine = i + 1;
                }
            }

            Console.WriteLine();
            Console.WriteLine(minLine + " Row has the smallest sum of elements");
        }
    }
}
