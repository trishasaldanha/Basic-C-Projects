using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace String_Functions_Practice
{
    class Program
    {
        static void Main(string[] args)
        {
            //string name = "Jesse";
            //string quote = "The man said, \"Hello, " +name + ".\" \n This is a new line. \n\t this is a tab.";
            //string fileName = @"C:\Users\awkbk4";
            //string fileName2 = "C:\\Users\\awkbk4";

            //bool trueOrFalse = name.Contains("s");
            //trueOrFalse = name.EndsWith("s");

            //int length = name.Length;

            //name = name.ToLower();

            //Console.WriteLine(name);
            //Console.ReadLine();

            StringBuilder sb = new StringBuilder("Hello, my name is Trisha. ");
            Console.WriteLine(sb);
            Console.ReadLine();

            sb.Append("I am 30 years old and I live in Portland, Oregon.");
            Console.WriteLine(sb);
            Console.ReadLine();

            sb.Append("I have a dog named Bernie.");
            Console.WriteLine(sb);
            Console.ReadLine();
        }
    }
}
