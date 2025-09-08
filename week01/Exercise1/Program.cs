using System;

class Program
{
    static void Main(string[] args)

    {
         //Prompt the user for their first name.
        Console.WriteLine("What is your first name? ");
        string first = Console.ReadLine();

        // //Prompt the user for their last name.
        Console.WriteLine("What is your last name? ");
        string last = Console.ReadLine();

        //Display the text back all on one line saying, "Your name is last-name, first-name, last-name".
        Console.WriteLine($"Your name is {last}, {first} {last}");
    }

}        
