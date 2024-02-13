using System;
using System.Threading;

class ReflectionActivity : Activity
{
    private string[] _prompts = {
        "Think of a time when you stood up for someone else.",
        "Think of a time when you helped someone in need.",
        "Think of a time when you stood up for the right thing.",
        "Think of a time when you achieved something really difficult.",
        "Think of a time when you overcame a hard situation.",
        "Think of a time when you felt the presence of the Lord."
    };

    public ReflectionActivity(string name, string description) : base(name, description) { }

    public override void Start()
    {
        base.Start();

        Console.WriteLine("Beginning reflection activity");

        Random random = new Random();
        string prompt = _prompts[random.Next(_prompts.Length)];

        Console.WriteLine(prompt);

        Thread.Sleep(3000);

        Console.WriteLine("Reflection activity completed");
        base.End();
    }
}
