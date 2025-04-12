namespace SRP.Solution;

public class PrintManager
{
    private readonly FileWriter _fileWriter = new();

    public void Print(Order order)
    {
        _fileWriter.FileWrite(order.Id, order.OrderItemsList);
    }
}