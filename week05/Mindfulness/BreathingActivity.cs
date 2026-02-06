public class BreathingActivity : Activity
{
    public BreathingActivity() : base("Breathing", "This activity will help you relax by guiding you through slow breathing exercises. Clear your mind and focus on your breath.")
    {
    }
    public void Run()
    {
        DisplayStartMessage();
        while (_duration > 0)
        {
             PerformBreathingCycle();
            _duration -= 10;
        }
        DisplayEndMessage();
    }
    private void PerformBreathingCycle()
    {
        Console.WriteLine("\nBreathe in...");
        ShowCountdown(4);
        Console.Clear();
        Console.WriteLine("\nBreathe out...");
        ShowCountdown(6);
        Console.Clear();
    }
}