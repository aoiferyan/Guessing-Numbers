using System;

namespace Guessing__Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            //set the variables
            String Name = "Guessing Numbers Game";
            String Version = "1.0";
            String Author = "Aoife Ryan";

            //change the text colour for the header
            Console.ForegroundColor = ConsoleColor.Blue;

            //Write to the console
            Console.WriteLine("{0}: Version {1} By {2}", Name, Version, Author);

            //Resets coour to default
            Console.ResetColor();
        }
    }   
}
