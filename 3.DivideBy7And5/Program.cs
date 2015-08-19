using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.DivideBy7And5
{
    class Program
    {
        static void Main(string[] args)
        {
            double inputNumber;
            Console.WriteLine("Insert number:");
            string numberValue = Console.ReadLine();
            inputNumber = double.Parse(numberValue);

            bool isTrue = (inputNumber % 5 == 0 || inputNumber % 7 == 0);
            
            Console.WriteLine(isTrue? true:false);
            
            
        }
    }
}
