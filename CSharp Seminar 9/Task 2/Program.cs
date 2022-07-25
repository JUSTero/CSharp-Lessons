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
            Console.WriteLine("Enter the lower number");
            int lowerNumber = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the upper number");
            int upperNumber = Convert.ToInt32(Console.ReadLine());
            Console.Write($"M = {lowerNumber}; N = {upperNumber} -> ");

            void Subsequence(int m, int n)
            {
                if (m < n)
                {
                    Console.Write($"{m} ");
                    Subsequence(m + 1, n);
                }

                else
                {
                    Console.Write(m);
                }
            }

            if (upperNumber < lowerNumber)
            {
                int temp = lowerNumber;
                lowerNumber = upperNumber;
                upperNumber = temp;
            }

            Subsequence(lowerNumber, upperNumber);
            Console.WriteLine();

        }
    }
}
