namespace LSP.Problem1;

public class PrintManager
{
    public void Print(Order order, IOrderWriter orderWriter)
    {
        if (orderWriter is EmailWriter emailWriter)
        {
           emailWriter.Initialize();        
        }
        
        orderWriter.Write(order.Id, order.OrderItemsList);
        Console.WriteLine("Order printed successfully.");
    }
}