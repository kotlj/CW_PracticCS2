using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace CW_PracticC_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter symbol");
            char symb = ' ';
            symb = Convert.ToChar(Console.ReadLine());
            Console.WriteLine("Enter number");
            int number = 0;
            number = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < number; i++)
            {
                Console.Write(symb);
            }
            Console.WriteLine(' ');

            //Task 2

            Console.WriteLine("Enter 5 numbers: ");
            int[] numbers = new int[5];
            for (int i = 0; i < 5; ++i)
            {
                numbers[i] = Convert.ToInt32(Console.ReadLine());
            }
            int min = int.MaxValue;
            int max = int.MinValue;
            int summ = 0;
            int multy = 1;
            for (int i = 0; i < 5; i++)
            {
                if (numbers[i] < min)
                {
                    min = numbers[i];
                }
                if (numbers[i] > max)
                {  
                    max = numbers[i];
                }
                summ += numbers[i];
                multy *= numbers[i];
            }
            Console.WriteLine("Min: " + min + "\nMax: " + max + "\nSumm: " + summ + "\nMulty: " + multy);
        }
    }
}
