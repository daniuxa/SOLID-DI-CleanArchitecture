namespace ISP.Solution;

public class Sparrow : IBird, IFlyingBird, ITweetingBird
{
    public void Fly()
    {
        Console.WriteLine("I'm flying");
    }

    public void Eat()
    {
        Console.WriteLine("I'm eating");
    }

    public void Tweet()
    {
        Console.WriteLine("I'm tweeting");
    }
}