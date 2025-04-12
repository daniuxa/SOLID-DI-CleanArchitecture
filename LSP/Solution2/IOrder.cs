namespace LSP.Solution2;

public interface IOrder
{
    public Guid Id { get; set; }
    
    public List<OrderItems> OrderItemsList { get; set; }

    public decimal CalculateTotalPrice();

    public void AddItem(Product product);
}