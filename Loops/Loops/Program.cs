using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loops
{
    class Program
    {
        static void Main(string[] args)
        {
            {
                //Boolean comparison using a while statement
                Console.WriteLine("pick a number:");
                int num1 = Convert.ToInt32(Console.ReadLine()), i = 0;

                while (i <= num1)
                {
                    Console.WriteLine(i);
                    i = i + 1;
                }
                Console.ReadLine();

                //Boolean comparison using a do-while statement
                Console.WriteLine("Guess a color: (please use all lower case)");
                string color = Console.ReadLine();
                bool isCorrect = color == "blue";

                do
                {
                    switch (color)
                    {
                        default:
                        Console.WriteLine("You guessed: " + color + ". That is not correct.");
                        Console.WriteLine("Guess a color:");
                        color = Console.ReadLine();
                            break;
                        case "blue":
                            Console.WriteLine("You guessed blue! That's correct!");
                        isCorrect = true;
                            break;
                    }
                    
                }
                while (isCorrect != true);

                Console.ReadLine();
            }
        }
    }
}
