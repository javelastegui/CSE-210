using System;
using System.Collections.Generic;
using System.IO;

public class QuestManager {
  private List<Goal> goals;
  public int TotalScore { get; private set; }

  public QuestManager() {
    goals = new List<Goal>();
    TotalScore = 0;
  }

  public void AddGoal(Goal goal) {
    goals.Add(goal);
  }

  public void RecordEvent(int goalIndex) {
    if (goalIndex >= 0 && goalIndex < goals.Count) {
      int earned = goals[goalIndex].RecordEvent();
      TotalScore += earned;
      Console.WriteLine($"Earned {earned} points!");
    }
  }

  public void DisplayGoals() {
      for (int i = 0; i < goals.Count; i++) {
        Console.WriteLine($"{i + 1}. {goals[i].GetGoalStatus()}");
      }
  }

  public void SaveGoals(string filename) {
    using (StreamWriter writer = new StreamWriter(filename)) {
      writer.WriteLine(TotalScore);
      foreach (var goal in goals) {
        writer.WriteLine(goal.GetStringRepresentation());
      }
    }
  }

  public void LoadGoals(string filename) {
    if (File.Exists(filename)) {
      string[] lines = File.ReadAllLines(filename);
      if (lines.Length > 0) {
        TotalScore = int.Parse(lines[0]);
        goals.Clear();
        for (int i = 1; i < lines.Length; i++) {
          string[] parts = lines[i].Split('|');
          switch (parts[0]) {
            case "SimpleGoal":
              goals.Add(SimpleGoal.CreateGoal(parts));
              break;
            case "EternalGoal":
              goals.Add(EternalGoal.CreateGoal(parts));
              break;
            case "ChecklistGoal":
              goals.Add(ChecklistGoal.CreateGoal(parts));
              break;
          }
        }
      }
    }
  }
}
