namespace DI_Implementation;

public class ServiceConsumer
{
    private readonly HelloService _hello;
    public ServiceConsumer(HelloService hello)
    {
        _hello = hello;
    }

    public void Print()
    {
        _hello.Print();
    }
}

public class HelloService
{
    private readonly MessageService _message;
    private readonly int _random;
    public HelloService(MessageService message)
    {
        _message = message;
        _random = new Random().Next();
    }

    public void Print()
    {
        Console.WriteLine($"Hello #{_random} World {_message.Message()}");
    }
}

public class MessageService
{
    private readonly int _random;
    public MessageService()
    {
        _random = new Random().Next();
    }

    public string Message()
    {
        return $"Yo #{_random}";
    }
}