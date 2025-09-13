using System;
using System.Collections.Generic;

public class PromptGenerator

//Your list of prompts must contain at least five different prompts.
//Make sure to add your own prompts to the list.
{
    public List<string> _prompts { get; set; }

    public PromptGenerator()
    {
        _prompts = new List<string>
        {
            "Who was the most interesting person I interacted with today?",
            "What was the best part of my day?",
            "How did I see the hand of the Lord in my life today?",
            "What was the strongest emotion I felt today?",
            "If I had one thing I could do over today, what would it be?",
            "What is something I'm gratefull for right now?",
            "What is a new skill I want to explore?"
        };
    }

    public string GetRandomPrompt()
    {
        Random random = new Random();
        int index = random.Next(_prompts.Count);
        return _prompts[index];
    }
}