public class Shape
{
    private string _color;

    public string GetColor()
    {
        string c = _color;
        return c;
    }
    public void SetColor(string color)
    {
        _color = color;
    }

    public Shape(string color)
    {
        _color = color;
    }

    public virtual double GetArea()
    {
        return 0;
    }
}