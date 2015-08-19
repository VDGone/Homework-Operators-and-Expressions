using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11.ExtractBit3
{
    class Program
    {
        static void Main(string[] args)
        {
            int number;
            Console.WriteLine("Enter your number: ");
            string nValue = Console.ReadLine();
            number = int.Parse(nValue);

            int changeBit = 1 << 3;
            int foundBit = number & changeBit;

            if (foundBit == 0)
            {
                Console.WriteLine("Third bit is '0'\n" + Convert.ToString(number, 2).PadLeft(16, '0'));
            }
            else
            {
                Console.WriteLine("Third bit is '1' " + Convert.ToString(number, 2).PadLeft(16, '0'));
            }
        }
    }
}
