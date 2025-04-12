namespace OCP.Solution;

public class EmailWriter : IOrderWriter
{
    public void Write(Guid orderId, IEnumerable<OrderItems> orderItems)
    {
    }
}