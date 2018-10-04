using System;


namespace Math_Operations_Drill
{
    class Program
    {
        static void Main(string[] args)
        {
            //1.Takes an input from the user, multiplies it by 50, and prints the result to the console. (Note: make sure your code can take inputs larger than 10, 000, 000).
            Console.WriteLine("Enter a number:");
            double num1 = double.Parse(Console.ReadLine());
            double total1 = num1 * 50;
            Console.WriteLine("Your number multiplied by 50 is: " + total1);
            Console.ReadLine();
            //2.Takes an input from the user, adds 25 to it, and prints the result to the console.
            Console.WriteLine("Enter another number:");
            int num2 = int.Parse(Console.ReadLine());
            int total2 = num2 + 25;
            Console.WriteLine("Your number plus 25 is: " + total2);
            Console.ReadLine();

            //3.Takes an input from the user, divides it by 12.5, and prints the result to the console.
            Console.WriteLine("Enter another number:");
            double num3 = double.Parse(Console.ReadLine());
            double total3 = num3 / 12.5;
            Console.WriteLine("Your number divided by 12.5 is: " + total3);
            Console.ReadLine();

            //4.Takes an input from the user, checks if it is greater than 50, and prints the true / false result to the console.
            Console.WriteLine("Enter another number:");
            int num4 = int.Parse(Console.ReadLine());
            bool trueOrFalse = num4 > 50;
            Console.WriteLine(trueOrFalse);
            Console.ReadLine();

            //5.Takes an input from the user, divides it by 7, and prints the remainder to the console(tip: think % operator).
            Console.WriteLine("Enter one more number:");
            int num5 = int.Parse(Console.ReadLine());
            int remainder = num5 % 7;
            Console.WriteLine(remainder);
            Console.ReadLine();
        }
    }
}
