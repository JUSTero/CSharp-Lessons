using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Seminar_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num = new Random().Next(10, 100);

            if (num / 10 > num % 10)
            {
                Console.WriteLine(num + " ==> " + num / 10);
            }

            else
            {
                Console.WriteLine(num + " ==> " + num % 10);
            }
        }
    }
}
