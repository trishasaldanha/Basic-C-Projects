using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operator_Overloading_Drill
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee employee1 = new Employee();
            Employee employee2 = new Employee();
            employee1.Id = 678;
            employee2.Id = 452;

            Console.WriteLine(employee1 == employee2);
            Console.ReadLine();
        }
    }
}
