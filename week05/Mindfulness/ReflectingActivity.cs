public class ReflectingActivity : Activity
{
    private List<Prompt> _prompts;
    private List<Prompt> _questions;

    public ReflectingActivity() : base("Reflecting", "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.")
    {
        _prompts = new List<Prompt>
        {
            new Prompt("Think of a time when you overcame a significant challenge."),
            new Prompt("Recall a moment when you helped someone in need."),
            new Prompt("Reflect on a situation where you demonstrated courage."),
            new Prompt("Remember a time when you achieved a personal goal."),
            new Prompt("Consider an experience where you learned something valuable about yourself.")
        };
        _questions = new List<Prompt>
        {
            new Prompt("What did you learn about yourself from this experience?"),
            new Prompt("How did this experience shape who you are today?"),
            new Prompt("What strengths did you discover during this time?"),
            new Prompt("How can you apply what you learned to future challenges?"),
            new Prompt("What positive impact did this experience have on your life?"),
            new Prompt("How did you feel during this experience and why?"),
            new Prompt("What would you do differently if faced with a similar situation again?"),
            new Prompt("Who supported you during this time and how did they help?"),
            new Prompt("What advice would you give to someone going through a similar experience?"),
            new Prompt("How has this experience influenced your outlook on life?")
        };
    }
    public void Run()
    {
        DisplayStartMessage();
        string prompt = GenerateUnusedPrompt(_prompts);
        Console.WriteLine("Consider the following prompt:");
        Console.WriteLine($"--- {prompt} ---");
        Console.WriteLine("Take a little time to ponder before we begin...");
        ShowSpinner(10);
        Console.Clear();
        Console.WriteLine("Now, reflect on the following questions related to your experience:");
        while (_duration > 0)
        {
            string question = GenerateUnusedPrompt(_questions);
            Console.WriteLine($"--- {question} ---");
            ShowSpinner(7);
            Console.Clear();
            _duration -= 7;
        }
        DisplayEndMessage();
    }
}