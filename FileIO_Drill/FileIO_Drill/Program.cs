using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace FileIO_Drill
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number.");
            string num1 = string.Format(Console.ReadLine() + "\n");
            using (StreamWriter file = new StreamWriter(@"C:\Users\awkbk4\C# Projects\Basic C# Projects\FileIO_Drill\textfile.txt", false))
            {
                file.WriteLine(num1);
            }
            Console.WriteLine(File.ReadAllText(@"C:\Users\awkbk4\C# Projects\Basic C# Projects\FileIO_Drill\textfile.txt"));
            Console.ReadLine();
        }
    }
}
