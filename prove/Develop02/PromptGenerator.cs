using System;
using System.Collections.Generic;
public class PromptGenerator{
    public List<string> _prompts = new List<string>
    {
        "What is your goal for this week to help you feel better on a daily?",
        "What did you find interesting or insightful about your day?",
        "How did you make sure you get closer to the Lord today?",
        "What really got you thinking today?",
        "If I had one thing I could do over today, what would it be?"


    };
    


public string GetRandomPrompt()
{
    Random random = new Random ();
    int index = random.Next(_prompts.Count);
    return _prompts[index];
        
    }

}