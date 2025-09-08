using System;

class Program
{
    static void Main(string[] args)

    //asking the user for the magic number.
    {
        //Console.WriteLine("What is the magic number?. ");
        //int magicNumber = int.Parse(Console.ReadLine());


        //generate a random number from 1 to 100.
        Random randomGenerator = new Random();
        int magicNumber = randomGenerator.Next(1, 101);

        int userGuess = -1;

        //Add a loop that keeps looping as long as the guess does not match the magic number.
        while (userGuess != magicNumber)
        {
            // //Ask the user for a guess.
            Console.Write("What is your guess? ");

        // we will change this to have the computer generate a random number, 
        // but to get started, we'll just let the user decide what it is.)
            userGuess = int.Parse(Console.ReadLine());

            //Using an if statement, determine if the user needs to guess higher or lower next time, 
            // or tell them if they guessed it.

            if (magicNumber > userGuess)
            {
                Console.WriteLine("Higher");
            }
            else if (magicNumber < userGuess)
            {
                Console.WriteLine("Lower");
            }
            else
            {
                Console.WriteLine("You guessed it!");
            }
        }
    }
}