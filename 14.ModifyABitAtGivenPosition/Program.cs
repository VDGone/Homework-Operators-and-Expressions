using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14.ModifyABitAtGivenPosition
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

            int value;
            string thirdNumber = Console.ReadLine();
            Console.Write("Value of bit [0 or 1]: ");
            value = int.Parse(thirdNumber);
 
            Console.WriteLine(Convert.ToString(number, 2).PadLeft(16, '0'));

            if (value == 1)
            {
                int setOne = 1 << position;
                int foundBitOne = number | setOne;
                Console.WriteLine(Convert.ToString(foundBitOne, 2).PadLeft(16, '0'));
                Console.WriteLine(foundBitOne);
            }
            else
            {
                int setZero = ~(1 << position);
                int foundBitZero = number & setZero;
                Console.WriteLine(Convert.ToString(foundBitZero, 2).PadLeft(16, '0'));
                Console.WriteLine(foundBitZero);
            }
        }
    }
}
