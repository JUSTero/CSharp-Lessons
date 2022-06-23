using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Lesson_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число");
            int number = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите количество значений");
            int count = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Таблица степеней числа " + number + " до " + count + " степени");

            for (int degree = 1; degree <= count; degree ++)
            {
                Console.WriteLine(number + " ^ " + degree + " = " + Math.Pow(number, degree));

            }
        }
    }
}
