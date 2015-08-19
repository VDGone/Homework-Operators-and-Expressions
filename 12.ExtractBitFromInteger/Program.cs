using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12.ExtractBitFromInteger
{
    class Program
    {
        static void Main(string[] args)
        {
            int number;
            Console.WriteLine("Enter your number: ");
            string firstNumber = Console.ReadLine();
            number = int.Parse(firstNumber);

            int position;
            Console.WriteLine("Check position: ");
            string secondNumber = Console.ReadLine();
            position = int.Parse(secondNumber);

            int changeBit = 1 << position;
            int foundBit = number & changeBit;

            if (foundBit == 0)
            {
                Console.WriteLine("The bit on position {0} is 0", position);
                Console.WriteLine(Convert.ToString(number, 2).PadLeft(16, '0'));
            }
            else
            {
                Console.WriteLine("The bit on position {0} is 1", position);
                Console.WriteLine(Convert.ToString(number, 2).PadLeft(16, '0'));
            }
        }
    }
}
