using System;

public class Task{

    public string Name {get; set;}
    public DateTime DueDate{get; set;}
    public int Priority{get;set;}


    public Task(string name, DateTime dueDate, int concern){

        Name = name;
        DueDate = dueDate;
         Priority = Priority;

    }

    public void DisplayDetails()
    {
        Console.WriteLine($"Task: {Name}");
        Console.WriteLine($"Due Date: {DueDate}");
        Console.WriteLine($"Priority: {Priority}");
        Console.WriteLine();
    }

    
    
    
}