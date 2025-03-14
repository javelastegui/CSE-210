using System;

public abstract class Goal {
  public string GoalName { get; set; }
  public string Description { get; set; }
  public int Points { get; set; }

  public Goal(string goalName, string description, int points) {
      GoalName = goalName;
      Description = description;
      Points = points;
  }
  public abstract int RecordEvent();
  public abstract bool IsComplete();
  public abstract string GetGoalStatus();
  public abstract string GetStringRepresentation();
}
