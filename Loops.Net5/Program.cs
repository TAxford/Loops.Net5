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
            /*for(int counter = 1; counter < 20; counter+=2)
            {
                Console.WriteLine(counter);
            }
            Console.WriteLine("Forloop is done");*/

            //Do while loop
            /*int lengthOfText =0;
            string wholeText = "";
            do
            {
                Console.WriteLine("Please enter the name of a friend");
                string nameOfAFriend = Console.ReadLine();
                int currentLength = nameOfAFriend.Length;
                lengthOfText += currentLength;
                wholeText += nameOfAFriend;
            }while(lengthOfText < 20);
            Console.WriteLine("Thanks, that was enough!" + wholeText);*/

            //While loop
            int counter = 0;
            while(counter < 10)
            {
                Console.WriteLine(counter);
                counter++;
            }



            Console.Read();

        }
    }
}
