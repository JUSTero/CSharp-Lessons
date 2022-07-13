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
            Console.WriteLine("Enter the numbers");
            int x = Convert.ToInt32(Console.ReadLine());
            int y = Convert.ToInt32(Console.ReadLine());
            int z = Convert.ToInt32(Console.ReadLine());

            if (x >= y + z)
            {
                Console.WriteLine("Triangle impossible");
            }

            else if (y >= z + x)
            {
                Console.WriteLine("Triangle impossible");
            }

            else if (z >= x + y)
            {
                Console.WriteLine("Triangle impossible");
            }

            else
            {
                Console.WriteLine("Triangle possible");
            }
        }
    }
}
