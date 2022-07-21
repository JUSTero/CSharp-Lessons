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
            int sizeArray = numbers.GetLength(0) * numbers.GetLength(1);
            Console.WriteLine("Original array:");

            CreateArray(numbers, lines, columns);
            PrintArray(numbers, lines, columns);

            for (int k = 0; k < lines; k++)
            {
                for (int t = 0; t < columns; t++)
                {
                    int count = 0;
                    int currentNumber = numbers[k, t];

                    if (currentNumber != -1)
                    {
                        Console.Write($"{numbers[k, t]}");
                    }
                    for (int i = 0; i < lines; i++)
                    {
                        for (int j = 0; j < columns; j++)
                        {
                            if (numbers[i, j] == currentNumber && currentNumber >= 0)
                            {
                                count++;
                                numbers[i, j] = -1;
                            }
                        }
                    }
                    if (currentNumber != -1)
                    {
                        Console.WriteLine($" meets {count} times");
                    }
                }
            }
        }
    }
}
