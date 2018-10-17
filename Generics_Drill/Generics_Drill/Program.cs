using System;
using System.Linq;

namespace Generics_Drill
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] string1 = { "one", "two" };
            Employee<string> emp1 = new Employee<string>();
            {
                emp1.Id = 7;
                emp1.Things = string1.ToList<string>();
            };
            int[] int1 = { 1, 2 };
            Employee<int> intList = new Employee<int>();
            {
                intList.Id = 9;
                intList.Things = int1.ToList<int>();
            }
            for (int i = 0; i < emp1.Things.Count; i++)
            {
                Console.WriteLine(emp1.Things[i]);
            }
            for (int j = 0; j < intList.Things.Count; j++)
            {
                Console.WriteLine(intList.Things[j]);
            }
            
            Console.ReadLine();
        }
    }
}
