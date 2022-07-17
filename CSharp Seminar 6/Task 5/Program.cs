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
            Console.WriteLine("Enter array lenght");
            int lenght = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter bottom limit");
            int botLim = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter top limit");
            int topLim = Convert.ToInt32(Console.ReadLine());
            
            int[] copy_num = new int [lenght];
            int[] num = new int[lenght];
            Random random = new Random();
            
            Console.WriteLine("Original array:");

            for (int i = 0; i < num.Length; i++)
            {
                num[i] = random.Next(botLim, topLim);
                Console.Write(" " + num[i] + " ");
            }

            Console.WriteLine();
            Console.WriteLine("Copied array:");

            for (int i = 0; i < num.Length; i++)
            {
                copy_num[i] = num[i];
                Console.Write(" " + copy_num[i] + " ");
            }

            Console.WriteLine();
        }
    }
}
