// For my full credit I made prompts into its own class and added a function to Activity to get a random unused prompt from a list of Prompt objects
class Program
{
    static void Main(string[] args)
    {
        void DisplayMenu()
        {
            Console.Clear();
            Console.WriteLine("+==================================+");
            Console.WriteLine("|     Welcome to the Mindfulness   |");
            Console.WriteLine("|             Activities           |");
            Console.WriteLine("+==================================+");
            Console.WriteLine("|     Please select an activity:   |");
            Console.WriteLine("------------------------------------");
            Console.WriteLine("| 1. Breathing Activity            |");
            Console.WriteLine("| 2. Listing Activity              |");
            Console.WriteLine("| 3. Reflecting Activity           |");
            Console.WriteLine("| 4. Exit                          |");
            Console.WriteLine("+==================================+");
        }
        BreathingActivity breathingActivity = new BreathingActivity();
        ListingActivity listingActivity = new ListingActivity();
        ReflectingActivity reflectingActivity = new ReflectingActivity();
        while (true)        {
            DisplayMenu();
            Console.Write("Enter your choice (1-4): ");
            string choice = Console.ReadLine();
            switch (choice)
            {
                case "1":
                    breathingActivity.Run();
                    break;
                case "2":
                    listingActivity.Run();
                    break;
                case "3":
                    reflectingActivity.Run();
                    break;
                case "4":
                    Console.WriteLine("Thank you for using the Mindfulness Activities. Goodbye!");
                    return;
                default:
                    Console.WriteLine("Invalid choice. Please enter a number between 1 and 4.");
                    System.Threading.Thread.Sleep(2000);
                    break;
            }
        }
    }
}