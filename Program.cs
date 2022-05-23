using System;

namespace GuessingGame
{
    class Program
    {
        static void Main(string[] args)
        {
            int index = 0;
            while (index < 4)
            {
                Console.WriteLine("Hey, guess a number!");
                string response = Console.ReadLine();
                int ParseResponse = int.Parse(response);
                int SecretNum = 81;
                if (ParseResponse == SecretNum)
                {
                    Console.WriteLine("Success!");
                }
                else
                {
                    Console.WriteLine("Your guess is {ParseResponse}");
                }
                Console.WriteLine($"You have {3 - index} more chances");
            }
            index++;

        }

    }
}




//The program should be updated to...

// Display the number of the user's current guess in the prompt. For example, if the user has already guessed one time, the prommpt should say something like Your guess (2)>.
// End the loop early if the user guesses the correct number.


