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
            Console.WriteLine(" Enter the number");
            int num = Convert.ToInt32(Console.ReadLine());
            string Binary = string.Empty;

            for (int i = 0; num > 0; i++)
            {
                Binary = Convert.ToString(num % 2) + Binary;
                num /= 2;
            }

            Console.WriteLine(Binary);
        }
    }
}
