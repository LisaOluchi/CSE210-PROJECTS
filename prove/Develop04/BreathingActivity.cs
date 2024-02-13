using System;
using System.Threading;

class BreathingActivity : Activity
{
    public BreathingActivity(string name, string description) : base(name, description) { }

    public override void Start()
    {
        base.Start();

        Console.WriteLine("Beginning breathing activity");

        Console.WriteLine("Be content, relax your mind and focus on your breathing");

        for (int i = 0; i < Duration; i++)
        {
            Console.WriteLine(i % 2 == 0 ? "Breathe in..." : "Breathe out...");
            Thread.Sleep(1000);
        }

        Console.WriteLine("Breathing activity done. Thank you, have a good day ahead.");
        base.End();
    }
}



