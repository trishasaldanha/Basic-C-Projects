using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operator_Overloading_Drill
{
    class Employee
    {
        public int Id { get; set; }

        public static bool operator== (Employee employee1, Employee employee2)
        {
            bool status = false;
            if (employee1.Id == employee2.Id)
            {
                status = true;
            }
            return status;
        }
        public static bool operator !=(Employee employee1, Employee employee2)
        {
            bool status = false;
            if (employee1.Id != employee2.Id)
            {
                status = false;
            }
            return status;
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
        public override bool Equals(object obj)
        {
            return base.Equals(obj);
        }
    }
}
