using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods_Drill_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Class1 class1 = new Class1();
            Console.WriteLine("Please enter a number.");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter an additional number or just press enter if you would like to skip this number.");
            try
            {
                int num2 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine(Class1.SomeMethod(num1, num2));
                Console.ReadLine();
                return;
            }
            
            catch
            {
                Console.WriteLine(Class1.SomeMethod(num1));
                Console.ReadLine();
                return;
            }
            
        }
    }
}
