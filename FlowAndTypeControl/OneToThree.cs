using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
Your program can create a random number between 1 and 3 with the following code:
int correctNumber = new Random().Next(3) + 1;
Write a program that generates a random number between 1 and 3 and asks the user to
guess what the number is. Tell the user if they guess low, high, or get the correct answer.
Also, tell the user if their answer is outside of the range of numbers that are valid guesses
(less than 1 or more than 3). You can convert the user's typed answer from a string to an
int using this code:
int guessedNumber = int.Parse(Console.ReadLine());
Note that the above code will crash the program if the user doesn't type an integer value.
For this exercise, assume the user will only enter valid guesses.
*/
namespace FlowAndTypeControl
{
    public class OneToThree
{
    public void GuessNum()
    { 
        int correctNumber = new Random().Next(3) + 1;
        Console.WriteLine("Guess our randomly generated number:");
        int guessedNumber = int.Parse(Console.ReadLine());
        if (guessedNumber < 1 || guessedNumber > 3)
        {
            Console.WriteLine("Out of our scope");
        }
        else
        {
            if (correctNumber == guessedNumber)
            {
                Console.WriteLine("Bingo!!");
            }
            else if (correctNumber > guessedNumber)
            {
                Console.WriteLine("your guess is less than the correct number");
            }
            else if (correctNumber < guessedNumber)
            {
                Console.WriteLine("your guess is above than the correct number");
            }
        }

    }
}
}
