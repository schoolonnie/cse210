public class ScriptureGenerator
{
    private string _chosenScripture;
    private List<string> _scriptureList = new List<string>()
    {
        "John,3,16|For God so loved the world, that he gave his only begotten Son, that whosoever believeth in him should not perish, but have everlasting life.",
        "Phillipians,4,13|I can do all things through Christ which strengtheneth me.",
        "Romans,8,28|And we know that all things work together for good to them that love God, to them who are the called according to his purpose.",
        "Proverbs,3,5,6|Trust in the Lord with all thine heart; and lean not unto thine own understanding. In all thy ways acknowledge him, and he shall direct thy paths.",
        "Jeremiah,29,11|For I know the thoughts that I think toward you, saith the Lord, thoughts of peace, and not of evil, to give you an expected end."
    };

    public void GenerateScripture()
    {
        Random random = new Random();
        int index = random.Next(_scriptureList.Count);
        _chosenScripture = _scriptureList[index];
    }

    public string GetReference()
    {
        string[] splitScripture = _chosenScripture.Split("|");
        return splitScripture[0];
    }

    public string GetBook()
    {
        string reference = GetReference();
        string[] splitReference = reference.Split(",");
        return splitReference[0];
    }

    public int GetChapter()
    {
        string reference = GetReference();
        string[] splitReference = reference.Split(",");
        return int.Parse(splitReference[1]);
    }

    public int GetVerse()
    {
        string reference = GetReference();
        string[] splitReference = reference.Split(",");
        return int.Parse(splitReference[2]);
    }

    public int GetEndVerse()
    {
        string reference = GetReference();
        string[] splitReference = reference.Split(",");
        if (splitReference.Length == 4)
        {
            return int.Parse(splitReference[3]);
        }
        else
        { 
            return 0;
        }
    }
    public string GetScripture()
    {
        string[] splitScripture = _chosenScripture.Split("|");
        return splitScripture[1];
    }
}