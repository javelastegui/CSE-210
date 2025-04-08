using System;

public class SwimmingActivity : Activity {
    private int laps;
    
    public SwimmingActivity(string date, int duration, int laps)
        : base(date, duration) {
        this.laps = laps;
    }
    
    public override double GetDistance() {
        return laps * 50 / 1000.0 * 0.62;
    }
    
    public override double GetSpeed() {
        double distance = GetDistance();
        return (distance / duration) * 60;
    }
    
    public override double GetPace() {
        double distance = GetDistance();
        return duration / distance;
    }
}
