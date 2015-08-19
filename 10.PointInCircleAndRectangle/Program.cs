using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10.PointInCircleAndRectangle
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

            bool isInCircle = (x - 1) * (x - 1) + (y - 1) * (y - 1) <= 1.5 * 1.5;
            bool outsideRectangle = x > 1 || x < 6 && y > -1 || y < 2;

            if (x == 0 || y == 0)
            {
                Console.WriteLine("no");
            }
            else if (isInCircle == true && outsideRectangle == true)
            {
                Console.WriteLine("yes");
            }
            else
            {
                Console.WriteLine("no");
            }
        }
    }
}
