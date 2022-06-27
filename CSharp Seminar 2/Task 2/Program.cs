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
            int num = Convert.ToInt32(Console.ReadLine());
            int temp = 0;
            
            if (num / 100 == 0)
            {
                Console.WriteLine("Нет третьей цифры");
            }

            else
            {
                while (num > 0)                              //Разворот числа
                {
                    temp *= 10;
                    temp += num % 10;
                    num /= 10;
                }

                num = temp / 100 % 10;
                Console.WriteLine(num);
            }
        }
    }
}