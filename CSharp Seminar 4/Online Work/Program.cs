using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Online_Task_1
{
    internal class Program
    {
        static void Main(string[] args)
        {            
            void sum(int num)
            {
                int tempSum = 0;
                for (int i = 1; i <= num; i++)
                {
                    tempSum += i;
                }

                Console.WriteLine(tempSum);
            }

            Console.WriteLine("Введите число");
            int number = Convert.ToInt32(Console.ReadLine());

            sum(number);

        }
    }
}
