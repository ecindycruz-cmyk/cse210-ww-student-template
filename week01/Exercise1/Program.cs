using System;

class Program
{
    static void Main(string[] args)
    {
        //Prompt the user for their first name
        Console.Write("What is your first name? ");
        string First_name = Console.ReadLine();

        //prompt them for their last name.
        Console.Write("What is your last name? ");
        string Last_name = Console.ReadLine();
        
        //Display the text back all on one line saying, "Your name is last-name, first-name, last-name"
        Console.WriteLine($"Your name is {Last_name}, {First_name} {Last_name}");

    }
}