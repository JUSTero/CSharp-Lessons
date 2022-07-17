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
            Console.WriteLine("Enter the numbers. For stop, send 'end'");
            int[] numbers = new int[0];
            int i = 0;
            int count = 0;

            while (true)
            {
                string number = Console.ReadLine();

                if (number == "end")
                {
                    break;
                }

                Array.Resize(ref numbers, numbers.Length + 1);
                numbers[i] = Convert.ToInt32(number);

                if (numbers[i] > 0)
                {
                    count++;
                }

                i++;
            }

            for (i = 0; i < numbers.Length; i++)
            {
                Console.Write(numbers[i] + " ");
            }

            Console.WriteLine();
            Console.WriteLine(count + " Numbers above zero");
        }
    }
}
