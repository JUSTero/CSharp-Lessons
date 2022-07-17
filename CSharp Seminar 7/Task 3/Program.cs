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
            {
                Console.WriteLine("Enter the number of lines");
                int lines = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter the number of columns");
                int columns = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter lower limit");
                int lowlim = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter upper limit");
                int uplim = Convert.ToInt32(Console.ReadLine());
                double[,] numbers = new double[lines, columns];
                Random random = new Random();

                Console.WriteLine("Original array:");

                for (int i = 0; i < lines; i++)
                {
                    for (int j = 0; j < columns; j++)
                    {
                        numbers[i, j] = random.Next(lowlim, uplim + 1);
                        Console.Write($"{numbers[i, j],5}");
                    }

                    Console.WriteLine();
                }
                Console.WriteLine();
                Console.WriteLine("Modified array:");

                for (int i = 0; i < lines; i++)
                {
                    for (int j = 0; j < columns; j++)
                    {
                        if (i % 2 == 0 && j % 2 == 0 && i != 0 && j != 0)
                        {
                            numbers[i, j] = Math.Pow(numbers[i, j], 2);
                        }

                        Console.Write($"{numbers[i, j],5}");
                    }

                    Console.WriteLine();
                }
            }
        }
    }
}
