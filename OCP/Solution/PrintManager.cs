namespace OCP.Solution;

public class PrintManager
{
    public void Print(Order order, IOrderWriter orderWriter)
    {
        orderWriter.Write(order.Id, order.OrderItemsList);
        Console.WriteLine("Order printed successfully.");
    }
}