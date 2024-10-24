using System;

class Program
{
    static void Main(string[] args)
    {
        Square sShape = new Square(2, "brown");
        Rectangle rShape = new Rectangle(5, 6, "red");
        Circle cShape = new Circle(7, "green");

        List<Shape> shapes = new List<Shape>();
        shapes.Add(sShape);
        shapes.Add(rShape);
        shapes.Add(cShape);

        
        foreach(Shape shape in shapes)
        {
            double area = shape.GetArea();
            string color = shape.GetColor();
            Console.WriteLine($"Color:{color}\nArea:{area}");
        }
        

    }
}