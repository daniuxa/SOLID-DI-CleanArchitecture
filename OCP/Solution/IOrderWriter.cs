namespace OCP.Solution;

public interface IOrderWriter
{
    public void Write(Guid orderId, IEnumerable<OrderItems> orderItems);
}