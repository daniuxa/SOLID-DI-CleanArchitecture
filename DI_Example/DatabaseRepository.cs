namespace DI_Example;

public class DatabaseRepository : IRepository
{
    public void Save(Guid orderId, IEnumerable<OrderItems> orders)
    {
        throw new NotImplementedException();
    }

    public IEnumerable<OrderItems> Load(Guid orderId)
    {
        throw new NotImplementedException();
    }
}