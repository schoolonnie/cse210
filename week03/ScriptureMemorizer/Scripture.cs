public class Scripture
{
    private Reference _reference;
    private List<Word> _words;
    
    public Scripture(Reference reference, string text)
    {
        _reference = reference;
        _words = new List<Word>();
        string[] splitScripture = text.Split(" ");
        foreach (string w in splitScripture)
        {
            Word word = new Word(w);
            _words.Add(word);
        }
    }
    
    public void HideRandomWords(int numberToHide)
    {
        Random random = new Random();
        for (int i = 0; i < numberToHide; i++)
        {
            int indexToHide = random.Next(_words.Count);
            _words[indexToHide].Hide();
        }
    }

    public void DisplayText()
    {
        Console.Write($"{_reference.GetDisplayText()} - ");
        foreach (Word word in _words)
        {
            if (word.IsHidden() == false)
            {
                Console.Write($"{word.GetDisplayText()} ");
            }
            else if (word.IsHidden() == true)
            {
                foreach (char c in word.GetDisplayText())
                {
                    Console.Write("_");
                }
            }
        }
    }

    public bool IsCompletelyHidden()
    {
        if (_words.All(w => w.IsHidden()))
        {
            return true;
        }
        else
        {
            return false;
        }
    }
}