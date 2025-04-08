using System;

public class CyclingActivity : Activity {
    private double speed;
    
    public CyclingActivity(string date, int duration, double speed)
        : base(date, duration) {
        this.speed = speed;
    }
    
    public override double GetDistance() {
        return speed * duration / 60.0;
    }
    
    public override double GetSpeed() {
        return speed;
    }
    
    public override double GetPace() {
        return 60.0 / speed;
    }
}
