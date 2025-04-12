namespace LSP.Problem1;

public class EmailWriter : IOrderWriter
{
    public void Write(Guid orderId, IEnumerable<OrderItems> orderItems)
    {
    }
    
    public void Initialize(){}
}