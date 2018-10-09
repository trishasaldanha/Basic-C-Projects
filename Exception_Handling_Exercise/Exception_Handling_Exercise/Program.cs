using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbersList = new List<int>();
        numbersList.Add(108);
        numbersList.Add(452);
        numbersList.Add(333);
        numbersList.Add(284);
        numbersList.Add(155);
        numbersList.Add(98);
        numbersList.Add(74);
        numbersList.Add(374);
        numbersList.Add(268);

        try
        {
            Console.WriteLine("Pick a number.");
            int num1 = Convert.ToInt32(Console.ReadLine()), i = 0, sizeOfList = numbersList.Count;
            Console.WriteLine("Dividing each number by " + num1 + ".");

            while (i < sizeOfList)
            {
                int divisor = numbersList[i] / num1;
                Console.WriteLine(numbersList[i] + " divided by " + num1 + " equals " + divisor + ".");

                i = i + 1;
            }
            Console.ReadLine();
        }
        catch (DivideByZeroException ex)
        {
            Console.WriteLine(ex.Message);
            return;
        }
        catch (FormatException ex)
        {
            Console.WriteLine(ex.Message);
            return;
        }
        finally
        {
            Console.WriteLine("Continuing with execution...");
            Console.ReadLine();
        }
        Console.ReadLine();
    }
}
