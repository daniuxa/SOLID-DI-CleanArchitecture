namespace LSP.Solution1;

public class EmailWriter : IOrderWriter, IInitializable
{
    public void Write(Guid orderId, IEnumerable<OrderItems> orderItems)
    {
    }
    
    public void Initialize(){}
}