using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.OddOrEvenIntegers
{
    class Program
    {
        static void Main(string[] args)
        {
            int a;
            Console.WriteLine("Insert number:");
            string numberValue = Console.ReadLine();
            a = int.Parse(numberValue);
            int result = a % 2;

            bool isTrue = true;

            if (result == 1)
            {
                Console.WriteLine(isTrue);
            }
            else if (result == 0)
            {
                Console.WriteLine(!isTrue);
            }
        }
    }
}