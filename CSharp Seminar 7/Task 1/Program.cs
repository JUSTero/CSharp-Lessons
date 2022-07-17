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

            for (int i = 0; i < lines; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    numbers[i, j] = random.Next(lowlim, uplim + 1);
                    Console.Write($"{numbers[i,j], 5}");
                }

                Console.WriteLine();
            }
        }
    }
}
