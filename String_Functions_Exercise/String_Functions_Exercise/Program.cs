using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace String_Functions_Exercise
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your name?");
            string name = Console.ReadLine();
            name = name.ToUpper();
            Console.WriteLine("How old are you?");
            string age = Console.ReadLine();
            Console.WriteLine("Where do you live?");
            string location = Console.ReadLine();
            location = location.ToUpper();
            StringBuilder sb = new StringBuilder("Hello, " + name + ", you are " + age + " years old and live in " + location + ".");
            sb.Append(" Adding a bunch of text to make a paragraph.");
            sb.Append(" I'm not sure \nhow much text I need to make a paragraph.");
            sb.Append(" I think a paragraph is at least five total sentences so this one makes four.");
            sb.Append("\nAnd here is the conclusion to this paragraph as well as to this drill.");
            Console.WriteLine(sb);
            Console.ReadLine();
        }
    }
}
