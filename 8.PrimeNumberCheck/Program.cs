using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8.PrimeNumberCheck
{
    class Program
    {
        static void Main(string[] args)
        {
            int number;
            Console.WriteLine("Enter your number: ");
            string nValue = Console.ReadLine();
            number = int.Parse(nValue);

            if (number == 1)
            {
                Console.WriteLine("This number is prime = False");
            }
            else
            {
                int primeCount = 0;
                for (int i = 1; i <= number; i++)
                {
                    if (number % i == 0)
                    {
                        primeCount++;
                    }
                }

                bool isPrime = true;

                if (primeCount > 2)
                {
                    isPrime = false;
                }

                Console.WriteLine("This number is prime = {0}",isPrime);
            }
        }
    }
}
