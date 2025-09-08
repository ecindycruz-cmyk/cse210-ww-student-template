using System;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>();

        //Ask the user for a series of numbers, and append each one to a list

        int userNumber = -1;
        while (userNumber != 0)
        {
            Console.Write("Enter a number (0 to quit): ");

            string userResponse = Console.ReadLine();
            userNumber = int.Parse(userResponse);

            //Add the number to the list, You should not add 0 to the list. 
            if (userNumber != 0)
            {
                numbers.Add(userNumber);
            }
        }
        //Compute the sum, or total, of the numbers in the list
        int sum = 0;
        foreach (int number in numbers)
        {
            sum += number;
        }

        Console.WriteLine($"The sum is: {sum}");

        //Compute the average of the numbers in the list.
        // I saw the sample solution in this part becuase I got a little confused
        float average = ((float)sum) / numbers.Count;
        Console.WriteLine($"The average is: {average}");

        //Find the maximum, or largest, number in the list.
        int max = numbers[0];

        foreach (int number in numbers)
        {
            if (number > max)
            {
                max = number;
            }
        }

        Console.WriteLine($"The max is: {max}");
    }
}