using System;
using System.Diagnostics.Tracing;
using System.Reflection;

namespace Loops.Net5
{
    internal class Program
    {
        
        static void Main(string[] args)
        {
            //for loop example
            for(int counter = 1; counter < 20; counter+=2)
            {
                Console.WriteLine(counter);
            }
            Console.WriteLine("Forloop is done");
            Console.Read();

        }
    }
}
