using DIP.Problem;

namespace DIP.Solution;

public class OrderRepository
{
    private readonly IRepository _repository;

    public OrderRepository(IRepository repository)
    {
        _repository = repository ?? throw new ArgumentNullException(nameof(repository));
    }

    public IEnumerable<OrderItems> Load(Guid orderId)
    {
        return _repository.Load(orderId).ToList();
    }

    public void Save(Order order)
    {
        _repository.Save(order.Id, order.OrderItemsList);
    }
}