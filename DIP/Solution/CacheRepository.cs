namespace DIP.Solution;

public class CacheRepository : IRepository
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