using System;

namespace Comparison_Operators_Drill
{
    class Program
    {
        static void Main(string[] args)
        {
            //Welcome
            Console.WriteLine("Anonymous Income Comparison Program");
            //Person 1
            Console.WriteLine("Person 1");
            Console.WriteLine("Hourly Rate?");
            int hourlyRate1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Hours worked per week?");
            int hoursWorked1 = int.Parse(Console.ReadLine());
            int weeklySalary1 = hourlyRate1 * hoursWorked1;
            //Person 2
            Console.WriteLine("Person 2");
            Console.WriteLine("Hourly Rate?");
            int hourlyRate2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Hours worked per week?");
            int hoursWorked2 = int.Parse(Console.ReadLine());
            int weeklySalary2 = hourlyRate2 * hoursWorked2;
            //Summary
            Console.WriteLine("Weekly salary of Person 1:");
            Console.WriteLine(weeklySalary1);
            Console.WriteLine("Weekly salary of Person 2:");
            Console.WriteLine(weeklySalary2);
            //Comparison
            bool isMore = weeklySalary1 > weeklySalary2;
            Console.WriteLine("Does Person 1 make more money than Person 2?");
            Console.WriteLine(isMore);
            Console.ReadLine();
        }
    }
}
