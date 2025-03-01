using System;
using System.Threading;

namespace MindfulnessProgram
{
  public abstract class Activity
  {
    protected string Name { get; set; }
    protected string Description { get; set; }
    protected int Duration { get; set; }

    public Activity(string name, string description)
    {
      Name = name;
      Description = description;
    }

    public void DisplayStartMessage()
    {
      Console.Clear();
      Console.WriteLine($"Welcome to the {Name}.");
      Console.WriteLine();
      Console.WriteLine(Description);
      Console.WriteLine();
      Console.Write("Enter duration in seconds: ");

      int duration;
      while (!int.TryParse(Console.ReadLine(), out duration))
      {
        Console.Write("Please enter a valid number: ");
      }
      Duration = duration;
      Console.WriteLine("Get ready to begin...");
      PauseAnimation(3);
    }

    public void DisplayEndMessage()
    {
      Console.WriteLine();
      Console.WriteLine("Well done!");
      PauseAnimation(3);
      Console.WriteLine($"You have completed the {Name} for {Duration} seconds.");
      PauseAnimation(3);
    }

    protected void PauseAnimation(int seconds)
    {
      int animationTime = seconds * 1000;
      int interval = 500;
      int cycles = animationTime / interval;
      for (int i = 0; i < cycles; i++)
      {
        Console.Write("|");
        Thread.Sleep(interval);
        Console.Write("\b \b");
      }
    }

    protected void Countdown(int seconds)
    {
      for (int i = seconds; i > 0; i--)
      {
        Console.Write(i);
        Thread.Sleep(1000);
        Console.Write("\b \b");
      }
    }

    public abstract void Run();
  }
}