namespace DIP.Problem;

public class OrderRepository
{
    private readonly DatabaseRepository _dbRepo = new();

    public IEnumerable<OrderItems> Load(Guid orderId)
    {
        return _dbRepo.Load(orderId).ToList();
    }

    public void Save(Order order)
    {
        _dbRepo.Save(order.Id, order.OrderItemsList);
    }
}