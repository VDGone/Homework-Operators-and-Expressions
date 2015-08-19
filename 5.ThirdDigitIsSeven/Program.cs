using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5.ThirdDigitIsSeven
{
    class Program
    {
        static void Main(string[] args)
        {
            int number;
            Console.WriteLine("Enter number: ");
            string nValue = Console.ReadLine();
            number = int.Parse(nValue);

            int checkNumber = ((number / 1000)*10 - number/100) % 7;

            if (number < 99)
            {
                Console.WriteLine("Third number is 7 = false");
            }
            else if (checkNumber == 0)
            {
                Console.WriteLine("Third number is 7 = true");
            }
            
            if (checkNumber != 0)
            {
                Console.WriteLine("Third number is 7 = false");
            }
        }
    }
}
