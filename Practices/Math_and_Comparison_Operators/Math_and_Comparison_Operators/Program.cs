﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Math_and_Comparison_Operators
{
    class Program
    {
        static void Main(string[] args)
        {
            //Addition
            int total = 5 + 10;
            int otherTotal = 12 + 22;
            int combined = total + otherTotal;
            Console.WriteLine(combined);
            Console.ReadLine();

            //Subraction
            int difference = 10 - 5;
            Console.WriteLine("Ten minus five = " + difference);
            Console.ReadLine();

            //Multiplication
            int product = 10 * 5;
            Console.WriteLine(product);
            Console.ReadLine();

            //Division
            int quotient = 100 / 5;
            Console.WriteLine(quotient);
            Console.ReadLine();

            //Modulus Operator
            int remainder = 11 % 2;
            Console.WriteLine(remainder);
            Console.ReadLine();

            //Comparison Operators
            bool trueOrFalse = 12 < 5;
            Console.WriteLine(trueOrFalse.ToString());
            Console.ReadLine();

            int roomTemperature = 70;
            int currentTemperature = 72;
            bool isWarm = currentTemperature > roomTemperature;
            Console.WriteLine(isWarm);
            Console.ReadLine();


        }
    }
}
