using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading;

class ReflectingActivity : Activity
{
    private List<string> _questions = new List<string>
    {
        "What did you discover about yourself through this experience?",
        "What part of this experience surprised you the most?",
        "At what moment did you feel most proud during this experience?",
        "How can you apply what you have learned to other areas of your life?",
        "What would you do differently next time to improve your experience?",
        "What do you value most about what you have achieved with this experience?",
        "How did this experience influence your personal or professional growth?",
        "How did you motivate yourself to keep going when you faced difficulties?"
        
    };
    private List<string> _usedQuestions = new List<string>();
    private List<string> _prompts = new List<string>
    {
        " Think of a time when you pushed yourself harder than usual to achieve a goal.",
        " Think of a time when you offered your support to someone going through a tough time.",
        " Think of a time when you felt incredibly grateful for something or someone.",
        " Think of a time when you inspired someone else through your actions.",
        " Think of a time when you learned a valuable lesson from a mistake you made.",
        " Think of a time when you realized how strong you really are"
    };

    private List<string> _usedPrompts = new List<string>();
    private Random _random;

    public ReflectingActivity(string name, string description, int duration)
        : base(name, description, duration)
    {
        _random = new Random();
    }

    public override void Run()
    {
        base.DisplayStartMessage();
        Console.Clear();
        Console.WriteLine("Get ready...");
        base.ShowSpinner(5);
        Console.WriteLine();

        string prompt = GetUniquePrompt();
        Console.WriteLine("Consider the following prompt:");
        Console.WriteLine();
        Console.WriteLine($"--- {prompt} ---");
        Console.WriteLine("When you have someting in mind, press enter.");
        Console.ReadLine();
        Console.WriteLine("Now ponder each of the following questions as they relate to this experience.");
        Console.WriteLine("You may being in:");
        base.ShowCountDown(5);

        Console.Clear();
        int questionCount = Math.Min(_questions.Count, _duration / 10);
        for (int i = 0; i < questionCount; i++)
        {
            string question = GetUniqueQuestion();
            Console.Write($"> {question} ");
            base.ShowSpinner(10);
            Console.WriteLine();
        }

        base.DisplayEndingMessage();
    }

     private string GetUniquePrompt()
    {
        if (_prompts.Count == 0)
        {
            _prompts.AddRange(_usedPrompts);
            _usedPrompts.Clear();
        }
        int index = _random.Next(_prompts.Count);
        string prompt = _prompts[index];
        _prompts.RemoveAt(index);
        _usedPrompts.Add(prompt);
        return prompt;
    }

    private string GetUniqueQuestion()
    {
        if (_questions.Count == 0)
        {
            _questions.AddRange(_usedQuestions);
            _usedQuestions.Clear();
        }
        int index = _random.Next(_questions.Count);
        string question = _questions[index];
        _questions.RemoveAt(index);
        _usedQuestions.Add(question);
        return question;
    }
}