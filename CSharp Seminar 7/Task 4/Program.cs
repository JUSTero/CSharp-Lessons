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
            Console.WriteLine("Enter the number of lines");
            int lines = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the number of columns");
            int columns = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter lower limit");
            int lowlim = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter upper limit");
            int uplim = Convert.ToInt32(Console.ReadLine());
            int[,] numbers = new int[lines, columns];
            Random random = new Random();
            int sum = 0;
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

            int a = 0;
            int b = 0;

            Console.WriteLine("The sum of the elements of the main diagonal:");
            while (a < numbers.GetLength(0) && b < numbers.GetLength(1))
            {
                sum += numbers[a, b];
                Console.Write(" " + numbers[a, b] + " ");

                if (a < numbers.GetLength(0) - 1 || b < numbers.GetLength(1) - 1)
                {
                    Console.Write("+");
                }

                a++;
                b++;
            }

            Console.WriteLine("= " + sum);
        }
    }
}
