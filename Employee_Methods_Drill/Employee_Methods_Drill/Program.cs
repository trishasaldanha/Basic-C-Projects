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
            List<Employee> empList = new List<Employee>();
            Employee emp1 = new Employee();
            emp1.FirstName = "Joe";
            emp1.LastName = "Roberts";
            emp1.Id = 1;

            Employee emp2 = new Employee();
            emp2.FirstName = "Ashley";
            emp2.LastName = "Devereaux";
            emp2.Id = 2;

            Employee emp3 = new Employee();
            emp3.FirstName = "Sarah";
            emp3.LastName = "Schute";
            emp3.Id = 3;

            Employee emp4 = new Employee();
            emp4.FirstName = "Joe";
            emp4.LastName = "Steen";
            emp4.Id = 4;

            Employee emp5 = new Employee();
            emp5.FirstName = "Will";
            emp5.LastName = "Cook";
            emp5.Id = 5;

            Employee emp6 = new Employee();
            emp6.FirstName = "Kylie";
            emp6.LastName = "Petti";
            emp6.Id = 6;

            Employee emp7 = new Employee();
            emp7.FirstName = "Matt";
            emp7.LastName = "Grow";
            emp7.Id = 7;

            Employee emp8 = new Employee();
            emp8.FirstName = "Lisa";
            emp8.LastName = "Scott";
            emp8.Id = 8;

            Employee emp9 = new Employee();
            emp9.FirstName = "Shannon";
            emp9.LastName = "Pattajo";
            emp9.Id = 9;

            Employee emp10 = new Employee();
            emp10.FirstName = "Nathan";
            emp10.LastName = "Goodell";
            emp10.Id = 10;

            empList.Add(emp1);
            empList.Add(emp2);
            empList.Add(emp3);
            empList.Add(emp4);
            empList.Add(emp5);
            empList.Add(emp6);
            empList.Add(emp7);
            empList.Add(emp8);
            empList.Add(emp9);
            empList.Add(emp10);
            
            foreach (Employee employee in empList)
            {
                if (employee.FirstName == "Joe")
                {
                    Console.WriteLine(employee.FirstName + " " + employee.LastName);
                }
            }

            List<Employee> newList = empList.Where(x => x.FirstName == "Joe").ToList();
            foreach (Employee employee in newList)
            {
                Console.WriteLine(employee.FirstName + " " + employee.LastName);
            }

            List<Employee> idList = empList.Where(x => x.Id > 5).ToList();
            foreach (Employee employee in idList)
            {
                Console.WriteLine(employee.FirstName + " " + employee.LastName); 
            }
            Console.ReadLine();
        }
    }
}
