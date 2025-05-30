using System;


interface IShape
{
    void Draw();
}


class Circle : IShape
{
    public void Draw()
    {
        Console.WriteLine("Drawing a Circle");
    }
}


class Rectangle : IShape
{
    public void Draw()
    {
        Console.WriteLine("Drawing a Rectangle");
    }
}


class ShapeFactory
{
    
    public IShape GetShape(string shapeType)
    {
        if (string.IsNullOrEmpty(shapeType))
            return null;

        if (shapeType.Equals("CIRCLE", StringComparison.OrdinalIgnoreCase))
            return new Circle();
        else if (shapeType.Equals("RECTANGLE", StringComparison.OrdinalIgnoreCase))
            return new Rectangle();

        return null;
    }
}


class Program
{
    static void Main(string[] args)
    {
        ShapeFactory factory = new ShapeFactory();

        IShape shape1 = factory.GetShape("CIRCLE");
        shape1?.Draw();  

        IShape shape2 = factory.GetShape("RECTANGLE");
        shape2?.Draw();  
    }
}

