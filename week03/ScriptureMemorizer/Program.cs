using System;

class Program
{
    static void Main(string[] args)
    {
        string userResponse = "";
        while (userResponse.ToLower() != "quit")
        {
            ScriptureGenerator scriptureGenerator = new ScriptureGenerator();
            scriptureGenerator.GenerateScripture();
            
            Reference reference;
            Scripture scripture;
            
            //check if there is a 2nd verse and reference accordingly
            if (scriptureGenerator.GetEndVerse() != 0)
            {
                reference = new Reference(scriptureGenerator.GetBook(), scriptureGenerator.GetChapter(), scriptureGenerator.GetVerse(), scriptureGenerator.GetEndVerse());
            }
            else
            {
                reference = new Reference(scriptureGenerator.GetBook(), scriptureGenerator.GetChapter(), scriptureGenerator.GetVerse());
            }
            scripture = new Scripture(reference, scriptureGenerator.GetScripture());
            
            //initial display with none hidden
            Console.Clear();
            Console.WriteLine("Press enter to take away words. Type 'quit' to exit or 'new' for a new scripture.");
            Console.WriteLine("+-------------------------------------------------------------------------------+");
            scripture.DisplayText();
            userResponse = Console.ReadLine();
            
            while (userResponse.ToLower() != "new" && userResponse.ToLower() != "quit" && !scripture.IsCompletelyHidden())
            {
                scripture.HideRandomWords(3);
                Console.Clear();
                Console.WriteLine("Press enter to take away words. Type 'quit' to exit or 'new' for a new scripture.");
                Console.WriteLine("+-------------------------------------------------------------------------------+");
                scripture.DisplayText();
                userResponse = Console.ReadLine();
            }
            if (scripture.IsCompletelyHidden())
            {
                Console.Clear();
                Console.WriteLine("You have completely hidden the scripture!");
                Console.WriteLine("Press enter to start a new.");
                Console.ReadLine();
            }
            if (userResponse.ToLower() == "quit")
            {
                break;
            }
        }
    }
}