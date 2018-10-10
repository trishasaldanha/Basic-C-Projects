using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Void_Method_Drill
{
    class Program
    {
        static void Main(string[] args)
        {
            Class1 class1 = new Class1();
            Class1.DoSomething(17, 25);
            Class1.DoSomething(num1: 300, num2: 75);
            
            Console.ReadLine();

        }
    }
}
