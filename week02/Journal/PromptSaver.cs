public class PromptSaver
{
    public void SavePromptsToFile(List<string> prompts, string filename)
    {
        using (StreamWriter writer = new StreamWriter(filename))
        {
            foreach (string prompt in prompts)
            {
                writer.WriteLine(prompt);
            }
        }
    }

    public List<string> LoadPromptsFromFile(string filename)
    {
        List<string> prompts = new List<string>();
        using (StreamReader reader = new StreamReader(filename))
        {
            string line;
            while ((line = reader.ReadLine()) != null)
            {
                prompts.Add(line);
            }
        }
        return prompts;
    }
}