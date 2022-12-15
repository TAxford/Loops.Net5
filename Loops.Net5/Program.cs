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
            for(int counter = 0; counter < 50; counter+=5)
            {
                Console.WriteLine(counter);
            }
            Console.WriteLine("Forloop is done");
            Console.Read();

        }
    }
}
