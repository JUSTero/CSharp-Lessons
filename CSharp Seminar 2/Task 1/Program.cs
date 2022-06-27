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
            Console.WriteLine("Введите трехзначное число");
            int num = Convert.ToInt32(Console.ReadLine());

            num = num / 10 % 10;
            Console.WriteLine(num);
        }
    }
}
