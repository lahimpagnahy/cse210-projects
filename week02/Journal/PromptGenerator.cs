using System;
using System.Collections.Generic;

class PromptGenerator
{
    private List<string> _prompts = new List<string>
    {
        "What was the best part of your day?",
        "What is something new you learned today?",
        "What made you smile today?",
        "Describe a challenge you faced today and how you handled it.",
        "Write about someone who made a difference in your day."
    };

    public string GetRandomPrompt()
    {
        Random rand = new Random();
        return _prompts[rand.Next(_prompts.Count)];
    }
}
