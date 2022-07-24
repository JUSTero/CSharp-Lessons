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
            int[,] matrix1 = new int[lines, columns];
            int[,] matrix2 = new int[lines, columns];
            int[,] matrixProduct = new int[lines, columns];
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

            CreateArray(matrix1, lines, columns);
            CreateArray(matrix2, lines, columns);
            Console.WriteLine("Created matrix:");
            Console.WriteLine();
            PrintArray(matrix1, lines, columns);
            Console.WriteLine();
            Console.WriteLine("And");
            Console.WriteLine();
            PrintArray(matrix2, lines, columns);
            Console.WriteLine();

            for (int i = 0; i < lines; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    matrixProduct[i, j] = matrix1[i, j] * matrix2[i, j];
                }
            }

            Console.WriteLine("Matrix product:");
            Console.WriteLine();
            PrintArray(matrixProduct, lines, columns);
            Console.WriteLine();
        }
    }
}
