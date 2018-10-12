using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enum_Drill
{
    class Program
    {
        enum DaysOfTheWeek { Monday, Tuesday, Wednesday, Thursday, Friday, Saturday, Sunday };

        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Enter a day of the week:");
                DaysOfTheWeek day = (DaysOfTheWeek)Enum.Parse(typeof(DaysOfTheWeek), Console.ReadLine(), true);
                int underlyingValue = Convert.ToInt32(day);
                Console.WriteLine("That is right, that is a day of the week!", underlyingValue);
                Console.ReadLine();
            }
            catch
            {
                Console.WriteLine("Please enter an actual day of the week.");
                Console.ReadLine();
            }
            
        }

    }
}
