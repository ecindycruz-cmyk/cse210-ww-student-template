using System;

class Program
{
    static void Main(string[] args)
    //Displays a message
    {
        DisplayWelcomeMessage();
        // Asks for and returns the user's name (as a string)
        string userName = PromptUserName();

        // Asks for and returns the user's favorite number (as an integer)
        int userNumber = PromptUserNumber();

        int squaredNumber = SquareNumber(userNumber);

        //Accepts the user's name and the squared number and displays them.
        DisplayResult(userName, squaredNumber);
    }

    static void DisplayWelcomeMessage()
    {
        Console.WriteLine("Welcome to the program!");
    }

    static string PromptUserName()
    {
        Console.Write("Please enter your name: ");
        string name_ = Console.ReadLine();

        return name_;
    }
        //Accepts an integer as a parameter and returns that number squared (as an integer)
    static int PromptUserNumber()
    {
        Console.Write("Please enter your favorite number: ");
        int number = int.Parse(Console.ReadLine());

        return number;
    }

    static int SquareNumber(int number)
    {
        int square = number * number;
        return square;
    }

    static void DisplayResult(string name_, int square)
    {
        Console.WriteLine($"{name_}, the square of your number is {square}");
    }
}