using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6.FourDigitNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int number;
            Console.Write("Enter your number: ");
            string nValue = Console.ReadLine();
            number = int.Parse(nValue);

            int firstDigit = number % 10;

            int restNumberTwo = number / 10;
            int secondDigit = restNumberTwo % 10;

            int restNumberThree = number / 100;
            int thirdDigit = restNumberThree % 10;

            int restNumberFour = number / 1000;
            int fourthDigit = restNumberFour % 10;

            Console.WriteLine("Sum of digits " + (firstDigit + secondDigit + thirdDigit + fourthDigit));
            Console.WriteLine("Reversed {0}{1}{2}{3}", firstDigit, secondDigit, thirdDigit, fourthDigit);
            Console.WriteLine("Last digit in front {0}{1}{2}{3}", firstDigit, fourthDigit, thirdDigit, secondDigit);
            Console.WriteLine("Second and third digits exchanged {0}{1}{2}{3}", fourthDigit, secondDigit, thirdDigit, firstDigit);
        }
    }
}
