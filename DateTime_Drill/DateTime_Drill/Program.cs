using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DateTime_Drill
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime date = DateTime.Now;
            Console.WriteLine("The current time is " + date);
            Console.WriteLine("Please type a number.");
            double num1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("The time in {0} hours from now is: {1}.", num1, date.AddHours(num1));
            Console.ReadLine();


        }
    }
}
