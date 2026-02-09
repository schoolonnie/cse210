class Program
{
    static void Main(string[] args)
    {
        Square square1 = new Square("green", 5);
        Rectangle rect1 = new Rectangle("blue", 11.2, 10);
        Circle cir1 = new Circle("red", 6);
        
        List<Shape> shapes = new List<Shape> {square1, rect1, cir1};

        foreach(var shape in shapes)
        {
            string shapeName = shape.GetType().Name;
            string shapeColor = shape.GetColor();
            double shapeArea = shape.GetArea();
            Console.WriteLine($"{shapeName} color - {shapeColor}");
            Console.WriteLine($"{shapeName} area - {shapeArea}");
        }
    }
}