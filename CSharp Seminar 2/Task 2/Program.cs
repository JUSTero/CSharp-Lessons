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

            int temp = Convert.ToInt32(num);

            if (num.Length < 3)
            {
                Console.WriteLine("Нет третьей цифры");
            }

            if (temp < 0)
            {
                Console.WriteLine(num[3]);
            }

            else
            {
                Console.WriteLine(num[2]);
            }
        }
    }
}