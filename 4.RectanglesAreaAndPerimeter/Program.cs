using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4.RectanglesAreaAndPerimeter
{
    class Program
    {
        static void Main(string[] args)
        {
            double width;
            Console.WriteLine("Enter width: ");
            string widthOfRectangle = Console.ReadLine();
            width = double.Parse(widthOfRectangle);

            double height;
            Console.WriteLine("Enter height: ");
            string heightOfRectangle = Console.ReadLine();
            height = double.Parse(heightOfRectangle);

            double perimeter = (2 * width) + (2 * height);
            double area = width * height;

            Console.WriteLine("Perimeter of rectangle is: {0}\nArea of rectangle is: {1}", perimeter, area);

        }
    }
}
