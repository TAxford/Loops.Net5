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
            /*int counter = 0;
            string enteredText = "";
            while(enteredText.Equals(""))
            {
                Console.WriteLine("Please press enter to increase amount by one and anything else" +  
                    "+ enter if you want to finish counting");
                enteredText = Console.ReadLine();
                counter++;
                Console.WriteLine("Current people count is {0}", counter);
            }*/


            //break and continue
            for(int counter = 0; counter < 10; counter++)
            {
                Console.WriteLine(counter);
                if(counter == 3)
                {
                    Console.WriteLine("At 3 we stop!");
                    break;
                }
                Console.Read();
            }

        }
    }
}
