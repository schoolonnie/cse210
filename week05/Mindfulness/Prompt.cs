public class Prompt
{
    private string _text;
    private bool _used;

    public Prompt(string text)
    {
        _text = text;
        _used = false;
    }
    public string PromptString()
    {
        return _text;
    }
    public void MarkUsed()
    {
        _used = true;
    }
    public bool IsUsed()
    {
        return _used;
    }
    public void Reset()
    {
        _used = false;
    }
    
}