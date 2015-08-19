using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.GravitationOnTheMoon
{
    class Program
    {
        static void Main(string[] args)
        {
            int manWeight;
            Console.WriteLine("Ïnsert your body weight: ");
            string mWeight = Console.ReadLine();
            manWeight = int.Parse(mWeight);

            double persentage = 0.17;
            double manWeightOnMoon =manWeight * persentage;

            Console.WriteLine("Your body weight on the moon will be: {0}", manWeightOnMoon);


        }
    }
}
