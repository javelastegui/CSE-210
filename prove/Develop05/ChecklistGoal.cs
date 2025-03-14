using System;

public class ChecklistGoal : Goal {
  private int requiredCount;
  private int currentCount;
  private int bonusPoints;

  public ChecklistGoal(string goalName, string description, int points, int requiredCount, int bonusPoints)
    : base(goalName, description, points) {
    this.requiredCount = requiredCount;
    this.bonusPoints = bonusPoints;
    this.currentCount = 0;
  }

  public override int RecordEvent() {
    if (!IsComplete()) {
      currentCount++;
      if (IsComplete()) {
        return Points + bonusPoints;
      }
      return Points;
    }
    return 0;
  }

  public override bool IsComplete() {
    return currentCount >= requiredCount;
  }

  public override string GetGoalStatus() {
    return (IsComplete() ? "[X]" : "[ ]") + $" {GoalName} ({Description}) -- Currently completed: {currentCount}/{requiredCount}";
  }

  public override string GetStringRepresentation() {
    return $"ChecklistGoal|{GoalName}|{Description}|{Points}|{requiredCount}|{currentCount}|{bonusPoints}";
  }

  public static ChecklistGoal CreateGoal(string[] parts) {
    ChecklistGoal goal = new ChecklistGoal(parts[1], parts[2], int.Parse(parts[3]),
      int.Parse(parts[4]), int.Parse(parts[6]));
    goal.currentCount = int.Parse(parts[5]);
    return goal;
  }
}
