namespace DIP.Solution;

public interface IRepository
{
    public void Save(Guid orderId, IEnumerable<OrderItems> orders);

    public IEnumerable<OrderItems> Load(Guid orderId);
}