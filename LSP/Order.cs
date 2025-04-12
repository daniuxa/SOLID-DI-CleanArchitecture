using LSP;
using LSP.Problem2;

public class Order : IOrder
{
    public Guid Id { get; set; }
    
    public List<OrderItems> OrderItemsList { get; set; }
    
    public decimal CalculateTotalPrice()
    {
        return OrderItemsList.Where((t, i) => (i + 1) % 3 != 0).Sum(t => t.Calculate());
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