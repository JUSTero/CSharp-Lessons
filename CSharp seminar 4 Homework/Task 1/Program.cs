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
            Console.WriteLine("Введите число");
            int num = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите степень");
            int degree = Convert.ToInt32(Console.ReadLine());
            int temp = num;

            for (int i = 1; i < degree; i++)
            {
                temp *= num;
            }

            Console.WriteLine(temp);
        }
    }
}
