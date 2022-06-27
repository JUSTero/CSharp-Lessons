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
            Console.WriteLine("Введите число");
            int num = Convert.ToInt32(Console.ReadLine());

            while (num > 7 || num < 1)
            {
                Console.WriteLine("Неприемлимое число, введите новое число");
                num = Convert.ToInt32(Console.ReadLine());
            }

            if (num == 6 || num == 7)
            {
                Console.WriteLine("Выходной!!!");
            }

            else
            {
                Console.WriteLine("Опять работа");
            }
        }
    }
}
