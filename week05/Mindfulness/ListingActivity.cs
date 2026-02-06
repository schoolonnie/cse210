public class ListingActivity : Activity
{
    private int _count;
    private List<Prompt> _prompts;
  
    
    public ListingActivity() : base("Listing", "This activity will help you reflect on the good things in your life by prompting you to list as many items as you can in a certain area.")
    {
        _prompts = new List<Prompt>
        {
            new Prompt("Who are people that you appreciate?"),
            new Prompt("What are personal strengths of yours?"),
            new Prompt("Who are people that you have helped this week?"),
            new Prompt("When have you felt the Holy Ghost this month?"),
            new Prompt("Who are some of your personal heroes?")
        };
    }
    public void Run()
    {
        DisplayStartMessage();
        string prompt = GenerateUnusedPrompt(_prompts);
        Console.WriteLine("Consider the following prompt:");
        Console.WriteLine($"--- {prompt} ---");
        Console.WriteLine("You have 10 seconds to ponder before we begin...");
        ShowCountdown(10);
        Console.Clear();
        Console.WriteLine($"You now have {_duration} seconds to list as many items as you can.");
        DateTime startTime = DateTime.Now;
        while ((DateTime.Now - startTime).TotalSeconds < _duration)
        {
            Console.Write("> ");
            string item = Console.ReadLine();
            if (!string.IsNullOrWhiteSpace(item))
            {
                _count++;
            }
        }
        Console.WriteLine($"You listed {_count} items! Great job!");
        DisplayEndMessage();
    }
}