using System;

namespace GuessingGame
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hey, guess a number!");
            string response = Console.ReadLine();
            Console.WriteLine($"Your guess is {response}.");

            int ParseResponse = int.Parse(response);
            int SecretNum = 81;
            if (ParseResponse == SecretNum)
            {
                Console.WriteLine("Success!");
            }
            else { Console.WriteLine("Failure!"); }
        }
    }
}


// Display a message to the user asking them to guess the secret number.
// Display a prompt for the user's guess.
// Take the user's guess as input and save it as a variable.
// Display the user's guess back to the screen.

