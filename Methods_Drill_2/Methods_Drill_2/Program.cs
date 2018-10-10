using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods_Drill_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Class1 class1 = new Class1();
            Console.WriteLine(Class1.MultiplyMe(12));
            Console.ReadLine();

            Class1 class2 = new Class1();
            int finalAnswer2 = Convert.ToInt32(Class1.MultiplyMe(7.8m));
            Console.WriteLine(finalAnswer2);
            Console.ReadLine();

            Class1 class3 = new Class1();
            int finalAnswer3 = Convert.ToInt32(Class1.MultiplyMe("8"));
            Console.WriteLine(finalAnswer3);
            Console.ReadLine();
        }
    }
}
