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

            int minI = 0;
            int minJ = 0;

            for (int i = 0; i < lines; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    if (numbers[i, j] <= numbers[minI, minJ])
                    {
                        minI = i;
                        minJ = j;
                    }
                }
            }

            int[,] finishedNumbers = new int[lines - 1, columns - 1];

            for (int i = 0; i < lines; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    if (i < finishedNumbers.GetLength(0) && j < finishedNumbers.GetLength(1))
                    {
                        if (i >= minI)
                        {
                            finishedNumbers[i, j] = numbers[i + 1, j];
                        }

                        else if (j >= minJ)
                        {
                            finishedNumbers[i, j] = numbers[i, j + 1];
                        }

                        else
                        {
                            finishedNumbers[i, j] = numbers[i, j];
                        }
                    }
                }
            }

            Console.WriteLine("Finished array:");
            PrintArray(finishedNumbers, lines - 1, columns - 1);
        }
    }
}
