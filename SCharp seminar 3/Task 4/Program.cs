using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите координату Ах");
            int ax = Convert.ToInt32 (Console.ReadLine());
            Console.WriteLine("Введите координату Аy");
            int ay = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите координату Bх");
            int bx = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите координату By");
            int by = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(Math.Sqrt(Math.Pow((ax - bx), 2) + Math.Pow((ay - by), 2)));
        }
    }
}
