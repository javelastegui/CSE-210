using System;

public class EternalGoal : Goal {

  public EternalGoal(string goalName, string description, int points)
    : base(goalName, description, points) { }

  public override int RecordEvent() {
    return Points;
  }

  public override bool IsComplete() {
    return false;
  }

  public override string GetGoalStatus() {
    return $"[ ] {GoalName} ({Description})";
  }

  public override string GetStringRepresentation() {
    return $"EternalGoal|{GoalName}|{Description}|{Points}";
  }

  public static EternalGoal CreateGoal(string[] parts) {
    return new EternalGoal(parts[1], parts[2], int.Parse(parts[3]));
  }
}
