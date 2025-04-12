namespace ISP.Problem;

public class Sparrow : IBird
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

    public void Swim()
    {
        throw new NotImplementedException();
    }
}