using System;
using System.Collections.Generic;

public class Program {
    public static void Main() {
        List<Activity> activities = new List<Activity>();
        activities.Add(new RunningActivity("15 OCT 2025", 45, 4.0));
        activities.Add(new CyclingActivity("02 NOV 2025", 90, 15.0));
        activities.Add(new SwimmingActivity("27 DEC 2025", 30, 22));
        
        foreach(Activity activity in activities) {
            Console.WriteLine(activity.GetSummary());
        }
    }
}
