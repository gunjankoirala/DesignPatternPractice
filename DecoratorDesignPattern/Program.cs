using System;

public interface ITea
{
    string GetDescription();
    double GetCost();
}

public class SimpleTea : ITea
{
    public string GetDescription()
    {
        return "Plain Tea";
    }

    public double GetCost()
    {
        return 10.0;
    }
}

public abstract class TeaWithSomething : ITea
{
    protected ITea someTea;

    public TeaWithSomething(ITea t)
    {
        someTea = t;
    }

    public virtual string GetDescription()
    {
        return someTea.GetDescription();
    }

    public virtual double GetCost()
    {
        return someTea.GetCost();
    }
}

public class LemonTea : TeaWithSomething
{
    public LemonTea(ITea t) : base(t)
    {

    }

    public override string GetDescription()
    {
        return someTea.GetDescription() + " with Lemon";
    }

    public override double GetCost()
    {
        return someTea.GetCost() + 2.0;
    }
}

public class HoneyTea : TeaWithSomething
{
    public HoneyTea(ITea t) : base(t)
    {

    }

    public override string GetDescription()
    {
        return someTea.GetDescription() + " with Honey";
    }

    public override double GetCost()
    {
        return someTea.GetCost() + 3;
    }
}

public class GingerTea : TeaWithSomething
{
    public GingerTea(ITea t) : base(t)
    {

    }

    public override string GetDescription()
    {
        return someTea.GetDescription() + " with Ginger";
    }

    public override double GetCost()
    {
        return someTea.GetCost() + 1.5;
    }
}

public class Program
{
    public static void Main(string[] args)
    {
        ITea myTea = new SimpleTea();
        myTea = new LemonTea(myTea);
        myTea = new HoneyTea(myTea);
        myTea = new GingerTea(myTea);

        Console.WriteLine("You ordered: " + myTea.GetDescription());
        Console.WriteLine("The price is: Rs. " + myTea.GetCost());
    }
}
