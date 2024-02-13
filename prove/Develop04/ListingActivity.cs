using System;
using System.Threading;

class ListingActivity : Activity
{
    public ListingActivity(string name, string description) : base(name, description)
    {
    }

    public override void Start()
    {
        base.Start();

        Console.WriteLine("Beginning the listing activity.");

        Console.WriteLine("Think about the following prompt:");
        string prompt = "Who are the people you are most grateful for in your life?";
        Console.WriteLine(prompt);

        Thread.Sleep(3000); 

        Console.WriteLine("Begin listing items:");

        int itemCount = 0;
        while (ElapsedTime < Duration)
        {
            string item = Console.ReadLine();
            if (item.ToLower() == "quit")
                break;
            itemCount++;
        }

        Console.WriteLine($"You listed {itemCount} items.");
        Console.WriteLine("Listing activity completed.");
        base.End();
    }
}
