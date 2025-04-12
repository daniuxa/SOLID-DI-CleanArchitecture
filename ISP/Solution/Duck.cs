namespace ISP.Solution;

public class Duck : IBird, IFlyingBird, IFloatingBird
{
    public void Fly()
    {
        Console.WriteLine("I'm flying");
    }

    public void Eat()
    {
        Console.WriteLine("I'm eating");
    }

    public void Swim()
    {
        Console.WriteLine("I'm swimming");
    }
}