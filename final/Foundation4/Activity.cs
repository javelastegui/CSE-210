using System;

public abstract class Activity {
    protected string date;
    protected int duration;
    
    public Activity(string date, int duration) {
        this.date = date;
        this.duration = duration;
    }
    
    public abstract double GetDistance();
    public abstract double GetSpeed();
    public abstract double GetPace();
    
    public virtual string GetSummary() {
        return $"{date} {this.GetType().Name} ({duration} min) | Distance: {GetDistance():F1} miles, Speed: {GetSpeed():F1} mph, Pace: {GetPace():F1} min per mile";
    }
}
