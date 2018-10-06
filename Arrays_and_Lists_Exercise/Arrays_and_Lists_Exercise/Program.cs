using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        string[] fortune1 = {"You will never get married. ", "You will die in a tragic accident. ", "You will die alone and poorly dressed.",
        "The person you desire feels the same about you. ", "Your shoes will make someone happy today. ", "A dream you have will come true. ", "A nightmare you have will come true. ",
        "You will be a failure. ", "You will make your own happiness. ", "You will travel to many exotic places in your life. "};
        int[] fortune2 = { 38, 42, 58, 104, 76, 88, 19, 27, 64, 95 };
        List<string> fortune3 = new List<string>();
        fortune3.Add("turtle");
        fortune3.Add("lion");
        fortune3.Add("elephant");
        fortune3.Add("owl");
        fortune3.Add("wolf");
        fortune3.Add("snail");
        fortune3.Add("snake");
        fortune3.Add("butterfly");
        fortune3.Add("sloth");
        fortune3.Add("koala");
        Console.WriteLine("Come! Have your fortune told!");
        Console.WriteLine("Pick a number between 0 and 9!");
        int i = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine(fortune1[i]);
        Console.ReadLine();
        Console.WriteLine("Pick another number between 0 and 9!");
        int j = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Your lucky number is: " + fortune2[j] + ".");
        Console.ReadLine();
        Console.WriteLine("Pick one last number between 0 and 9!");
        int k = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Your spirit animal is the " + fortune3[k] + ".");
        Console.ReadLine();
    }
}
