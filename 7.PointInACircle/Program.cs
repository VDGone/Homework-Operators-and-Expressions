using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7.PointInACircle
{
    class Program
    {
        static void Main(string[] args)
        {
            double x;
            Console.WriteLine("Enter x = ");
            string xCoordinate = Console.ReadLine();
            x = double.Parse(xCoordinate);

            double y;
            Console.WriteLine("Enter y = ");
            string yCoordinate = Console.ReadLine();
            y = double.Parse(yCoordinate);

            bool isInCircle = (((x - 1) * (x - 1)) + ((y - 1) * (y - 1))) <= 2 * 2;

            if (x == 0 || y == 0)
            {
                Console.WriteLine("The point is in the circle.");
            }
            else
            {
                Console.WriteLine("The point is not in the circle.");
            }
        }
    }
}
