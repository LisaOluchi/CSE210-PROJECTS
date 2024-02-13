using System;

public class Activity
{
    private string _name;
    private string _description;
    private int _durationInSeconds;
    private DateTime _startTime;
    private DateTime _endTime;

    public Activity(string name, string description)
    {
        _name = name;
        _description = description;
    }

    public virtual void Start()
    {
        Console.WriteLine($"Starting: {_name} activity...");
        Console.WriteLine($"Description: {_description}");

        Console.Write("Enter duration in seconds: ");
        _durationInSeconds = int.Parse(Console.ReadLine());

        Console.WriteLine("Prepare to begin...");
        Pause(3);

        _startTime = DateTime.Now;

        DoActivity();

        _endTime = DateTime.Now;

        TimeSpan duration = _endTime - _startTime;

        Console.WriteLine($"You have completed the {_name} activity! Duration: {duration.TotalSeconds} seconds");
        Pause(5);
    }

    protected virtual void DoActivity()
    {
        // Implemented in derived classes
    }

    protected void Pause(int seconds)
    {
        for (int i = seconds; i > 0; i--)
        {
            Console.Write($"{i} ");
            System.Threading.Thread.Sleep(1000);
        }
        Console.WriteLine();
    }

    public int ElapsedTime
    {
        get
        {
            TimeSpan elapsed = DateTime.Now - _startTime;
            return (int)elapsed.TotalSeconds;
        }
    }

    public int Duration
    {
        get { return _durationInSeconds; }
    }

    public void End()
    {
        // cleanup logic 
    }
}
