using System;
using System.Threading;

namespace MindfulnessProgram
{
  public class BreathingActivity : Activity
  {
    public BreathingActivity() : base("Breathing Activity",
      "This activity will help you relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing.")
    {
    }

    public override void Run()
    {
      DisplayStartMessage();

      DateTime startTime = DateTime.Now;
      DateTime endTime = startTime.AddSeconds(Duration);
      while (DateTime.Now < endTime)
      {
        Console.Write("Breathe in... ");
        Countdown(4);
        Console.WriteLine();

        Console.Write("Breathe out... ");
        Countdown(6); 
        Console.WriteLine();
      }

      DisplayEndMessage();
    }
  }
}
