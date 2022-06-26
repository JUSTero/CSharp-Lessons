using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Lecture_2
{
    internal class Program
    {
        static void Main(string[] args)                                   //Fillarray(array);
                                                                          //Printarray(array);
        {
            void Fillarray(int[] length)

            {
                Random c = new Random();

                for (int i1 = 0; i1 < length.Length; i1++)
                {
                    length[i1] = c.Next();
                }
            }

            void Printarray(int[] list)

            {
                for (int i2 = 0; i2 < list.Length; i2++)
                {
                    Console.WriteLine(list[i2]);
                }
            }
            int[] array = new int[0];
            int size = 1;
            int index = 0;
            while (true)
            {
                string word = Console.ReadLine();                

                if (word != "end")
                {
                    int num = Convert.ToInt32(word);
                    Array.Resize(ref array, size);
                    array[index] = num;
                    index++;
                    size++;
                }
                else
                {
                    Printarray(array);
                    break;
                }
            }            
        }
    }
}
