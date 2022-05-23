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
                else { Console.WriteLine("Failure!"); }
                index++;

            }

        }
    }
}




// Give the user four chances to guess the number.
// Continue to display the success or failure messages as in phase 2


