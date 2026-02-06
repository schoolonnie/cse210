public class Activity
{
    private string _name;
    private string _description;
    protected int _duration;
    private int _initialDuration;

    public Activity(string name, string description)
    {
        _name = name;
        _description = description;
    }
    public void DisplayStartMessage()
    {
        Console.WriteLine("How long would you like to do the activity? (Enter a number in seconds)");
        _duration = int.Parse(Console.ReadLine());
        _initialDuration = _duration;
        Console.Clear();
        Console.WriteLine($"Starting {_name} activity...");
        Console.WriteLine(_description);
        Console.WriteLine(" ");
        Console.WriteLine("Get ready to start...");
        ShowSpinner(8);
        Console.Clear();
    }
    public void DisplayEndMessage()
    {
        Console.WriteLine($"You have completed the {_name} activity for {_initialDuration} seconds. Well done! Returning to menu...");
        ShowSpinner(5);
    }
    public void ShowSpinner(int seconds)
    {
        string[] spinner = { "|", "/", "-", "\\" };
        int spinnerIndex = 0;
        for (int i = 0; i < seconds * 4; i++)
        {
            Console.Write(spinner[spinnerIndex]);
            spinnerIndex = (spinnerIndex + 1) % spinner.Length;
            System.Threading.Thread.Sleep(250);
            Console.Write("\b");
        }
    }
    public void ShowCountdown(int seconds)
    {
        for (int i = seconds; i > 0; i--)
        {
            Console.Write(i + " ");
            System.Threading.Thread.Sleep(1000);
            Console.Write("\b\b\b");
        }
    }
    public string GenerateUnusedPrompt(List<Prompt> prompts)
    {
        Random rand = new Random();
        int promptIndex = rand.Next(prompts.Count);
        Prompt selectedPrompt = prompts[promptIndex];
        while (true)
        {
            if (!(selectedPrompt.IsUsed()))
            {
                selectedPrompt.MarkUsed();
                return selectedPrompt.PromptString();
            }
            else if (prompts.All(p => p.IsUsed()))
            {
                Console.WriteLine("All prompts have been used. Resetting prompts...");
                foreach (var prompt in prompts)
                {
                    prompt.Reset();
                }
            }
            else if (selectedPrompt.IsUsed())
            {
                promptIndex = rand.Next(prompts.Count);
                selectedPrompt = prompts[promptIndex];
            }
        }
    }
}