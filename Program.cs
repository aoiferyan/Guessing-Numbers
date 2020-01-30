using System;

namespace Guessing__Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            //Method called for app info
            GetAppInfo();

            //method called to greet user
            GreetUser();

            //while loop
            while (true)
            {
                //declare property
                //int correctnumber = 7;

                //create a random number
                Random random = new Random();

                int correctnumber = random.Next(1, 10);


                int number = 0;

                //ask user for number
                Console.WriteLine("Guess a number between 1 and 10....");

                //if number is wrong
                while (number != correctnumber)
                {
                    string input = Console.ReadLine();

                    if (!int.TryParse(input, out number))
                    {
                        
                        //Print error message
                        PrintColourMessage(ConsoleColor.Red, "This isn't a number! Try again...");

                        //keep going
                        continue;
                    }

                    number = Convert.ToInt32(input);

                    //match number to correctnumber
                    if (number != correctnumber)
                    {

                        //Print error message
                        PrintColourMessage(ConsoleColor.Red, "Wrong number!please try again");
                      
                    }

                }

                //Print error message
                PrintColourMessage(ConsoleColor.Green, "You are Correct!!!!!");

                Console.ReadLine();

                //ask to play again?
                Console.WriteLine("Do you want to play again? [Y Or N]");

                //Get Answer
                string answer = Console.ReadLine().ToUpper();


                if(answer == "Y")
                {
                    continue;
                }
                else if(answer == "N")
                {
                    return;
                }
                else
                {
                    return;
                }
            }
        }

        //Method with App Information
        static void GetAppInfo()
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

        //Method that greets user
        static void GreetUser()
        {
            //Ask users name
            Console.WriteLine("What is your name?");

            //Get user input name
            string username = Console.ReadLine();

            //welcome the user by name
            Console.WriteLine($"Hello {username}! Let's play a game......");

        }

        //Method to print colour message

        static void PrintColourMessage(ConsoleColor colour, string message)
        {
            //change the text colour for the header
            Console.ForegroundColor = colour;

            //Write to the console
            Console.WriteLine(message);

            //Resets coour to default
            Console.ResetColor();
        }
    }   
}
