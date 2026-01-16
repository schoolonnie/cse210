// For my full credit, I added a submenu for managing custom prompts. You can add, remove, save , and load prompts from this second menu.

using System;

class Program
{
    static void Main(string[] args)
    {
        Journal journal = new Journal();
        PromptGenerator promptGenerator = new PromptGenerator();
        bool running = true;

        while (running)
        {
            Console.WriteLine("+-----------------------------+");
            Console.WriteLine("++------ Journal  Menu ------++");
            Console.WriteLine("+-----------------------------+");
            Console.WriteLine("1. Write a new entry");
            Console.WriteLine("2. Display all entries");
            Console.WriteLine("3. Load entries from a file");
            Console.WriteLine("4. Save entries to a file");
            Console.WriteLine("5. Custom prompts menu");
            Console.WriteLine("6. Quit");
            Console.WriteLine("+-----------------------------+");
            Console.Write("Select an option (1-6): ");
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    Entry newEntry = new Entry();
                    newEntry._date = DateTime.Now.ToString("yyyy-MM-dd");
                    newEntry._promptText = promptGenerator.GetRandomPrompt();
                    Console.WriteLine($"Here is your prompt: {newEntry._promptText}");
                    Console.Write("Your entry: ");
                    newEntry._entryText = Console.ReadLine();
                    journal.AddEntry(newEntry);
                    break;

                case "2":
                    journal.DisplayAll();
                    break;

                case "3":
                    Console.Write("Enter filename to load from: ");
                    string loadFilename = Console.ReadLine();
                    journal.LoadFromFile(loadFilename);
                    Console.WriteLine("Entries loaded successfully!");
                    break;

                case "4":
                    Console.Write("Enter filename to save to: ");
                    string saveFilename = Console.ReadLine();
                    journal.SaveToFile(saveFilename);
                    Console.WriteLine("Entries saved successfully!");
                    break;

                case "5":
                    bool inPromptMenu = true;
                    while (inPromptMenu)
                    {
                        PromptSaver promptSaver = new PromptSaver();

                        Console.WriteLine("+-----------------------------+");
                        Console.WriteLine("++--- Custom Prompts Menu ---++");
                        Console.WriteLine("+-----------------------------+");
                        Console.WriteLine("1. View all prompts");
                        Console.WriteLine("2. Add a new prompt");
                        Console.WriteLine("3. Remove a prompt");
                        Console.WriteLine("4. Save prompts to file");
                        Console.WriteLine("5. Load prompts from file");
                        Console.WriteLine("6. Return to main menu");
                        Console.WriteLine("+-----------------------------+");
                        Console.Write("Select an option (1-6): ");
                        string promptChoice = Console.ReadLine();

                        switch (promptChoice)
                        {
                            case "1":
                                Console.WriteLine("Current Prompts:");
                                for (int i = 0; i < promptGenerator._prompts.Count; i++)
                                {
                                    Console.WriteLine($"{i + 1}. {promptGenerator._prompts[i]}");
                                }
                                break;

                            case "2":
                                Console.Write("Enter the new prompt: ");
                                string newPrompt = Console.ReadLine();
                                promptGenerator._prompts.Add(newPrompt);
                                Console.WriteLine("Prompt added successfully!");
                                break;

                            case "3":
                                Console.WriteLine("For a list of prompts and their index numbers, use menu item 1. Enter 0 to cancel.");
                                Console.Write("Enter the number of the prompt to remove: ");
                                if (int.TryParse(Console.ReadLine(), out int promptIndex) &&
                                    promptIndex > 0 && promptIndex <= promptGenerator._prompts.Count)
                                {
                                    promptGenerator._prompts.RemoveAt(promptIndex - 1);
                                    Console.WriteLine("Prompt removed successfully!");
                                }
                                else if (promptIndex == 0)
                                {
                                    Console.WriteLine("Prompt removal canceled.");
                                }
                                else
                                {
                                    Console.WriteLine("Invalid prompt number.");
                                }
                                break;
                        
                            case "4": 
                                Console.Write("Enter filename to save prompts to: ");
                                promptSaver.SavePromptsToFile(promptGenerator._prompts, Console.ReadLine());
                                Console.WriteLine("Prompts saved successfully!");
                                break;
                            case "5":
                                Console.Write("Enter filename to load prompts from: ");
                                promptGenerator._prompts = promptSaver.LoadPromptsFromFile(Console.ReadLine());
                                Console.WriteLine("Prompts loaded successfully!");
                                break;

                            case "6":
                                inPromptMenu = false;
                                break;

                            default:
                                Console.WriteLine("Invalid option. Please try again. Enter a number 1-6.");
                                break;
                        }
                    }
                    break;

                case "6":
                    running = false;
                    break;

                default:
                    Console.WriteLine("Invalid option. Please try again. Enter a number 1-6.");
                    break;
            }
        }
    }
}