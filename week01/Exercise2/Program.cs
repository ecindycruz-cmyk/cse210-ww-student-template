using System;

class Program
{
    static void Main(string[] args)
    {
        //Ask the user for their grade percentage
        Console.WriteLine("What is your grade percentage?.");
        string answer_user = Console.ReadLine();
        int percent = int.Parse(answer_user);

        //create a new variable called letter and then in each block, 
        //set this variable to the appropriate value. 
        string letter = "";

        //Add a separate if statement to determine if the user passed the course
        //Change your code from the first part, 
        // so that instead of printing the letter grade in the body of each 
        // if, else if, or else block.

        if (percent >= 90)
        {
            letter = "A";
        }
        else if (percent >= 80)
        {
            letter = "B";
        }
        else if (percent >= 70)
        {
            letter = "C";
        }
        else if (percent >= 60)
        {
            letter = "D";
        }
        else
        {
            letter = "F";
        }
        //You'll have a separate print statement for each grade letter in the appropriate block.
        Console.WriteLine($"Your grade is: {letter}");
        
        if (percent >= 70)
        
        //display a message to congratulate them.
        {
            Console.WriteLine("You passed!");
        }
        //If not, display a different message to encourage them for next time
        {
            Console.WriteLine("Better luck next time!");
        }

    }
}
    