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
            Console.WriteLine("Enter k1");
            double k1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter k2");
            double k2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter b1");
            double b1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter b2");
            double b2 = Convert.ToDouble(Console.ReadLine());

            if (k1 == k2)
            {
                Console.WriteLine("No intersection point. Lines are parallel");
            }

            else
            {
                double x = (b2 - b1) / (k1 - k2);
                double y1 = k1 * x + b1;
                double y2 = k2 * x + b2;

                Console.WriteLine("Intersection point coordinates: x = " + x + " y = " + y1);
            }
        }
    }
}
