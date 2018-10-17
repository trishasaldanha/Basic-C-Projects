using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exception_Handling_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("How old are you?");
            try
            {
                int userAge = Convert.ToInt32(Console.ReadLine());
                if (userAge < 1)
                {
                    Console.WriteLine("Please enter a valid age. (No negative numbers or zero.)");
                    Console.ReadLine();
                    return;
                }
                int UserAgeDays = userAge * 365;
                TimeSpan yearsAlive = TimeSpan.FromDays(UserAgeDays);
                DateTime now = DateTime.Now;
                DateTime dateOfBirth = now - yearsAlive;
                Console.WriteLine(dateOfBirth.Year);
                Console.ReadLine();
            }
            catch (FormatException ex)
            {
                Console.WriteLine(ex.Message);
                Console.ReadLine();
                return;
            }
        }
    }
}
