using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Boolean_Logic
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your age?");
            int age = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("Have you ever had a DUI?");
            bool dui = bool.Parse(Console.ReadLine());
            Console.WriteLine("How many speeding tickets do you have?");
            int speedingTickets = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("Qualified?");
            Console.WriteLine(age > 15 && dui == false && speedingTickets <= 3);
            Console.ReadLine();
        }
    }
}
