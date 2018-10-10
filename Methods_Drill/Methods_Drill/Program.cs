using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods_Drill
{
    class Program
    {
        static void Main(string[] args)
        {
            int digitOne = 0, finalAnswer1, finalAnswer2, finalAnswer3;
            Console.WriteLine("Pick a number.");
            digitOne = Convert.ToInt32(Console.ReadLine());

            finalAnswer1 = Class1.addMe(digitOne);
            finalAnswer2 = Class1.multiplyMe(digitOne);
            finalAnswer3 = Class1.subtractMe(digitOne);
            Console.WriteLine(digitOne + " plus 100 is " + finalAnswer1 + ".");
            Console.WriteLine(digitOne + " multiplied by 25 is " + finalAnswer2 + ".");
            Console.WriteLine(digitOne + " minus 5 is " + finalAnswer3 + ".");

            
            Console.ReadLine();
        }
    }
}
