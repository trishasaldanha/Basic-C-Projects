using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee_Methods_Drill
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee employee = new Employee();
            employee.FirstName = "Student";
            employee.LastName = "Sample";
            employee.SayName();
            Console.ReadLine();
        }
    }
}
