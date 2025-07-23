/*
Code project 1 - write code that validates integer input
Here are the conditions that your first coding project must implement:

Your solution must include either a do-while or while iteration.

Before the iteration block: your solution must use a Console.WriteLine() statement to prompt the user for an integer value between 5 and 10.

Inside the iteration block:

Your solution must use a Console.ReadLine() statement to obtain input from the user.
Your solution must ensure that the input is a valid representation of an integer.
If the integer value isn't between 5 and 10, your code must use a Console.WriteLine() statement to prompt the user for an integer value between 5 and 10.
Your solution must ensure that the integer value is between 5 and 10 before exiting the iteration.
*/
using System;

namespace CodeProject
{
    class CodeProject
    {
       public static void Main(string[] args)
        {
            string? userInput;
            int validValue = 0;
            bool isValid = false;

            Console.WriteLine("Enter an integer value between 5 and 10");

            do
            {
                userInput = Console.ReadLine();
                isValid = int.TryParse(userInput, out validValue);

                if (isValid)
                {
                    if (validValue < 5 || validValue > 10)
                    {
                        isValid = false;
                        Console.WriteLine("Invalid input. Please enter an integer value between 5 and 10.");
                    }
                }
                else
                {
                    Console.WriteLine("That was not a valid integer. Please try again.");
                }

            } while (!isValid);

            Console.WriteLine($"Your input value ({validValue}) has been accepted.");
        }
    }
}
