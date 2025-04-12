namespace SRP.Solution;

public class Order
{
    public Guid Id { get; set; }
    
    public List<OrderItems> OrderItemsList { get; set; }
    
    public decimal Calculate()
    {
        return OrderItemsList.Sum(items => items.Calculate());
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