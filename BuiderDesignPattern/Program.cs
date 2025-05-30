using System;


class Box
{
    private string size;
    private string color;
    private string label;

    public void SetSize(string size)
    {
        this.size = size;
    }

    public void SetColor(string color)
    {
        this.color = color;
    }

    public void SetLabel(string label)
    {
        this.label = label;
    }

    public override string ToString()
    {
        return $"Box [Size: {size}, Color: {color}, Label: {label}]";
    }
}


interface BoxBuilder
{
    void BuildSize();
    void BuildColor();
    void BuildLabel();
    Box GetBox();
}


class GiftBoxBuilder : BoxBuilder
{
    private Box box = new Box();

    public void BuildSize()
    {
        box.SetSize("Medium");
    }

    public void BuildColor()
    {
        box.SetColor("Red with Golden Ribbon");
    }

    public void BuildLabel()
    {
        box.SetLabel("Happy Birthday!");
    }

    public Box GetBox()
    {
        return box;
    }
}


class BoxDirector
{
    private BoxBuilder builder;

    public BoxDirector(BoxBuilder builder)
    {
        this.builder = builder;
    }

    public void ConstructBox()
    {
        builder.BuildSize();
        builder.BuildColor();
        builder.BuildLabel();
    }

    public Box GetBox()
    {
        return builder.GetBox();
    }
}

class Program
{
    static void Main(string[] args)
    {
        BoxBuilder builder = new GiftBoxBuilder();
        BoxDirector director = new BoxDirector(builder);
        director.ConstructBox();
        Box box = director.GetBox();

        Console.WriteLine(box);
    }
}
