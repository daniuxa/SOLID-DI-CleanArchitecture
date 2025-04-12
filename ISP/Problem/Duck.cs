namespace ISP.Problem;

public class Duck : IBird
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
        throw new NotImplementedException();
    }

    public void Swim()
    {
        Console.WriteLine("I'm swimming");
    }
}