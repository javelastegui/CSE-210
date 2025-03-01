using System;
using System.Collections.Generic;
using System.Threading;

namespace MindfulnessProgram
{
  public class ListingActivity : Activity
  {
    private List<string> prompts = new List<string>()
    {
      "Who are people that you appreciate?",
      "What are personal strengths of yours?",
      "Who are people that you have helped this week?",
      "When have you felt the Holy Ghost this month?",
      "Who are some of your personal heroes?"
    };

    public ListingActivity() : base("Listing Activity",
      "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.")
    {
    }

    public override void Run()
    {
      DisplayStartMessage();

      Random rand = new Random();
      int promptIndex = rand.Next(prompts.Count);
      Console.WriteLine();
      Console.WriteLine(prompts[promptIndex]);
      Console.WriteLine("You have 5 seconds to think...");
      Countdown(5);
      Console.WriteLine();

      Console.WriteLine("Start listing your items. Press enter after each item.");
      Console.WriteLine("When you are finished (or time is up), simply press enter on an empty line.");

      DateTime startTime = DateTime.Now;
      DateTime endTime = startTime.AddSeconds(Duration);
      int itemCount = 0;
      while (DateTime.Now < endTime)
      {
        string input = Console.ReadLine();
        if (string.IsNullOrWhiteSpace(input))
        {
          break;
        }
        itemCount++;
      }

      Console.WriteLine();
      Console.WriteLine($"You listed {itemCount} item(s).");
      DisplayEndMessage();
    }
  }
}
