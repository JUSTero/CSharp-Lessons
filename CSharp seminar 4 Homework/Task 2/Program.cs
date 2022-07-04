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
            int sum = 0;

            while (num > 0)
            {
                sum += num % 10;
                num /= 10;
            }

            Console.WriteLine(sum);
        }
    }
}
