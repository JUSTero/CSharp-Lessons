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
            int[,] numbers = new int[4, 4];
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
                int count = 1;
                int i = 0;
                int j = 0;

                for (j = 0; j < n; j++)
                {
                    array[i, j] = count;
                    count++;
                }

                j = numbers.GetLength(1) - 1;

                for (i = 1; i < numbers.GetLength(0); i++)
                {
                    numbers[i, j] = count;
                    count++;
                }

                i = numbers.GetLength(0) - 1;

                for (j = numbers.GetLength(1) - 2;j >= 0; j--)
                {
                    numbers[i, j] = count;
                    count++;
                }

                j = 0;

                for (i = numbers.GetLength(0) - 2; i > 0; i--)
                {
                    numbers[i, j] = count;
                    count++;
                }

                i = numbers.GetLength(0) - 3;

                for (j = numbers.GetLength(1) - 3; j < numbers.GetLength(1) - 1; j++)
                {
                    numbers[i, j] = count;
                    count++;
                }

                numbers[numbers.GetLength(0) - 2, numbers.GetLength(1) - 2] = count;
                count++;

                numbers[numbers.GetLength(0) - 2, numbers.GetLength(1) - 3] = count;

                return array[m - 1, n - 1];
            }

            CreateArray(numbers, numbers.GetLength(0), numbers.GetLength(1));
            Console.WriteLine("Created array:");
            PrintArray(numbers, numbers.GetLength(0), numbers.GetLength(1));
        }
    }
}
