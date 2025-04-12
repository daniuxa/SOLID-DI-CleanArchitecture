namespace LSP.Problem2;

public class DiscountedOrder : IOrder
{
    public Guid Id { get; set; }
    public List<OrderItems> OrderItemsList { get; set; }
    
    public int DiscountPercent { get; set; }
    
    public decimal CalculateTotalPrice()
    {
        return OrderItemsList.Sum(t => t.Calculate()) * (100 - DiscountPercent) / 100;
    }

    public void AddItem(Product product)
    {
        if (OrderItemsList.Any(items => items.Product.Id == product.Id))
        {
            OrderItemsList.First(items => items.Product.Id == product.Id).Quantity++;   
        }
        else
        {
            OrderItemsList.Add(new OrderItems { Product = product, Quantity = 1 });
        }
    }
}