namespace LSP.Solution1;

public class PrintManager
{
    public void Print(Order order, IOrderWriter orderWriter)
    {
        if (orderWriter is IInitializable initializableWriter)
        {
           initializableWriter.Initialize();        
        }
        
        orderWriter.Write(order.Id, order.OrderItemsList);
        Console.WriteLine("Order printed successfully.");
    }
}