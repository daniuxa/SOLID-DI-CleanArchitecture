namespace DI_Example;

public interface IRepository
{
    public void Save(Guid orderId, IEnumerable<OrderItems> orders);

    public IEnumerable<OrderItems> Load(Guid orderId);
}