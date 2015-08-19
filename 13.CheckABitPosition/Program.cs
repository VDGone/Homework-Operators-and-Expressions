using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13.CheckABitPosition
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

            int moveBit = number >> position;
            int foundBit = moveBit & 1;

            bool isOne = foundBit == 1;

            Console.WriteLine(Convert.ToString(number, 2).PadLeft(16, '0'));
            Console.WriteLine("Bit of position {0} is '1' = {1}", position, isOne);
        }
    }
}
