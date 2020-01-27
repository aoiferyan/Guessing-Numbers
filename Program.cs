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

            //Ask users name
            Console.WriteLine("What is your name?");

            //Get user input name
            string username = Console.ReadLine();

            //welcome the user by name
            Console.WriteLine($"Hello {username}! Let's play a game......");


            //declare property
            int correctnumber = 7;
            int number = 0;

            //ask user for number
            Console.WriteLine("Guess a number between 1 and 10....");

            //if number is wrong
            while (number != correctnumber)
            {
                string input = Console.ReadLine();

                number = Convert.ToInt32(input);

                //match number to correctnumber
                if (number != correctnumber)
                {
                    //change the text colour for the header
                    Console.ForegroundColor = ConsoleColor.Red;

                    //Write to the console
                    Console.WriteLine("Wrong number! please try again");

                    //Resets coour to default
                    Console.ResetColor();
                }

            }

            //If correct
            Console.WriteLine("You are correct");

        }
    }   
}
