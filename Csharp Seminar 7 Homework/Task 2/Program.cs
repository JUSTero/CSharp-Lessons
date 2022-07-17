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
            Console.WriteLine("Enter lower limit");
            int lowlim = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter upper limit");
            int uplim = Convert.ToInt32(Console.ReadLine());
            Random random = new Random();
            int[,] numbers = new int[columns, columns];
            Console.WriteLine("Created array:");

            for (int i = 0; i < lines; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    numbers[i, j] = random.Next(lowlim, uplim);
                    Console.Write($"{numbers[i, j], 5}");
                }

                Console.WriteLine();
            }

            Console.WriteLine("Enter the disired position");
            Console.WriteLine("line:");
            int spline = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Column:");
            int spcolumn = Convert.ToInt32(Console.ReadLine());

            if (spline >= numbers.GetLength(0)  || spcolumn >= numbers.GetLength(1))
            {
                Console.WriteLine("Such a number does not existin the array");
            }

            else
            {
                Console.WriteLine("Disired number = " + numbers[spline, spcolumn]);
            }
        }
    }
}
