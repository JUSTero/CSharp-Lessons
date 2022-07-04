using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Online_Task_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число");
            string num = Console.ReadLine();
            int temp = Convert.ToInt32(num);
            
            if (temp < 0)
            {
                Console.WriteLine(num.Length - 1);
            }

            else
            {
                Console.WriteLine(num.Length);
            }
        }
    }
}
