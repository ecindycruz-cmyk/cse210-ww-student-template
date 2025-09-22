using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        //Store a scripture, including both the reference (for example "John 3:16") 
        // and the text of the scripture.
        // var reference = new Reference("John", 3, 16);
        //string text = For God so loved the world, that he gave his only begotten Son; " , 
        // "that whosoever believeth in him should not perish, but have everlasting life.";

        //Accommodate scriptures with multiple verses, such as "Proverbs 3:5-6".
        //Clear the console screen and display the complete scripture, including the reference and the text.

        var reference = new Reference("Proverbs", 3, 5, 6);
        string text = "Trust in the Lord with all thine heart; and lean not unto thine own understanding. " +
                      " In all thy ways acknowledge him, and he shall direct thy paths.";
        var Scripture = new Scripture(reference, text);


        //Prompt the user to press the enter key or type quit.
        //If the user types quit, the program should end.
        while (true)
        {
            Console.Clear();
            Console.WriteLine(Scripture.GetDisplayText());
            Console.WriteLine();
            Console.Write("Press Enter to hide words or type 'quit' to exit:");

            string input = Console.ReadLine()?.Trim().ToLowerInvariant();
            if (input == "quit")
                break;

            Scripture.HideRandomWords(numberToHide: 3);

            if (Scripture.IsComplete1yHidden())
            {
                Console.Clear();
                Console.WriteLine(Scripture.GetDisplayText());
                Console.WriteLine("\n(All words are hidden. Program will end.)");
                break;
            }
        }
    }
}