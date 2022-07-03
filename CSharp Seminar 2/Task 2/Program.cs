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
            Console.WriteLine("Введите число");
            string num = Console.ReadLine();

            if (num.Length < 3)
            {
                Console.WriteLine("Нет третьей цифры");
            }

            else
            {
                Console.WriteLine(num[2]);
            }
        }
    }
}