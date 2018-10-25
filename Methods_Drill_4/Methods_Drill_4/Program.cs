using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods_Drill_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Class1 newClass = new Class1();
            Console.WriteLine("Pick a number.");
            int num1 = Convert.ToInt32(Console.ReadLine());
            newClass.voidMethod(num1, out int num2);
            Console.ReadLine();
        }
    }
}
