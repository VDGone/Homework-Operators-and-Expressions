using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9.TrapezoidArea
{
    class Program
    {
        static void Main(string[] args)
        {
            float a;
            Console.WriteLine("Enter number for side a: ");
            string aValue = Console.ReadLine();
            a = float.Parse(aValue);

            float b;
            Console.WriteLine("Enter number for side b: ");
            string bValue = Console.ReadLine();
            b = float.Parse(bValue);

            double h;
            Console.WriteLine("Enter number for height: ");
            string hValue = Console.ReadLine();
            h = double.Parse(hValue);

            double Area = ((a + b) * h) / 2;
            Console.WriteLine("Area is {0}.", Area);
        }
    }
}
