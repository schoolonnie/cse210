using System;

class Program
{
    static void Main(string[] args)
    {
        RunningActivity runningActivity = new RunningActivity(3.47, 33);
        CyclingActivity cyclingActivity = new CyclingActivity(22.1, 42);
        SwimmingActivity swimmingActivity = new SwimmingActivity(10, 31);

        List<Activity> activities = new List<Activity>{runningActivity, cyclingActivity, swimmingActivity};

        foreach(Activity activity in activities)
        {
            activity.GetSummary();
        }
    }
}