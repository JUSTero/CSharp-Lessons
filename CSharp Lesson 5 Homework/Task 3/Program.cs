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
            Console.WriteLine("Enter array lenght");
            int lenght = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter bottom limit");
            int botLim = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter top limit");
            int topLim = Convert.ToInt32(Console.ReadLine());
            Random random = new Random();
            int[] num = new int[lenght];
            Console.WriteLine("Create array:");
            int max = num[0];
            int min = num[0];

            for (int i = 0; i < num.Length; i++)
            {
                num[i] = random.Next(botLim, topLim);
                Console.Write($"{num[i], 5}");
            }
            
            for (int i = 0; i < num.Length; i++)
            {
                if (num[i] > max)
                {
                    max = num[i];
                }

                else if (num[i] < min)
                {
                    min = num[i];
                }
            }

            Console.WriteLine();
            Console.WriteLine("Result: " + (max - min));
        }
    }
}
