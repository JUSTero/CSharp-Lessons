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
            Console.WriteLine("Enter array lenght");
            int lenght = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter bottom limit");
            int botLim = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter top limit");
            int topLim = Convert.ToInt32(Console.ReadLine());
            int[] num = new int[lenght];
            int temp = 0;
            int size = lenght - 1;
            Random random = new Random();

            Console.WriteLine("Create array:");

            for (int i = 0; i < lenght; i++)
            {
                num[i] = random.Next(botLim, topLim);
            }

            Console.WriteLine(String.Join(" ", num));
            Console.WriteLine("Reverse array:");

            for (int i = 0; i < lenght / 2; i++)
            {
                temp = num[i];
                num[i] = num[size - i];
                num[size - i] = temp;
            }

            Console.WriteLine(String.Join(" ", num));
        }

       
    }
}
