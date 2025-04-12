namespace ISP.Problem;

public class ToyDuck : IBird
{
    public void Fly()
    {
        throw new NotImplementedException();
    }

    public void Eat()
    {
        throw new NotImplementedException();
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