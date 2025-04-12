namespace DI_Example;


public interface IOrderRepository
{
    public IEnumerable<Product> GetAllProductsInOrder(Guid orderId);

    public decimal GetPriceOfOrder(Guid orderId);

    public void SaveOrders(Order order);
}