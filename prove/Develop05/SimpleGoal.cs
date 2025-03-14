using System;

public class SimpleGoal : Goal {
  private bool completed;

  public SimpleGoal(string goalName, string description, int points)
  : base(goalName, description, points) {
  completed = false;
}

public override int RecordEvent() {
  if (!completed) {
    completed = true;
    return Points;
  }
  return 0;
}

public override bool IsComplete() {
  return completed;
}

public override string GetGoalStatus() {
  return (completed ? "[X]" : "[ ]") + $" {GoalName} ({Description})";
}

public override string GetStringRepresentation() {
  return $"SimpleGoal|{GoalName}|{Description}|{Points}|{completed}";
}

public static SimpleGoal CreateGoal(string[] parts) {
    SimpleGoal goal = new SimpleGoal(parts[1], parts[2], int.Parse(parts[3]));
    goal.completed = bool.Parse(parts[4]);
    return goal;
  }
}
