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
            Console.WriteLine("Enter array lenght");
            int lenght = Convert.ToInt32 (Console.ReadLine());
            int[] numbers = new int[lenght];
            Console.WriteLine("Enter bottom limit");
            int botLimit = Convert.ToInt32 (Console.ReadLine());
            Console.WriteLine("Enter top limit");
            int topLimit = Convert.ToInt32 (Console.ReadLine());
            Random random = new Random();
            Console.Write("Create massiv => ");
            for (int i = 0; i < lenght; i++)
            {
                numbers[i] = random.Next(botLimit, topLimit);
                Console.Write($"{numbers[i], 5}  ");
            }

            Console.WriteLine();
            Console.Write("Result =>        ");

            for (int i = 0; i < lenght; i++)
            {
                numbers[i] *= -1;
                Console.Write($"{numbers[i], 5}  ");
            }

            Console.WriteLine();
        }
    }
}
