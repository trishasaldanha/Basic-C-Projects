using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Branching_Drill
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Package Express. Please follow the instructions below.");
            Console.WriteLine("What is the package weight?");
            int weight = Convert.ToInt32(Console.ReadLine());
            if (weight > 50)
            {
                Console.WriteLine("Package is too heavy to be shipped via Package Express. Have a good day.");
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("How wide is the package?");
                int width = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("What is the height of the package?");
                int height = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("What is the length of the package?");
                int length = Convert.ToInt32(Console.ReadLine());
                int totalDimensions = width + height + length;
                if (totalDimensions > 50)
                {
                    Console.WriteLine("Package too big to be shipped via Package Express.");
                    Console.ReadLine();
                }
                else
                {
                    int quote = totalDimensions * weight / 100;
                    Console.WriteLine("Your estimated total for shipping this package is: $" + quote + ".");
                    Console.WriteLine("Thank you.");
                    Console.ReadLine();
                }
            }
        }
    }
}
