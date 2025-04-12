namespace OCP;

public class OrderItems
{
    public Product Product { get; set; }
    
    public int Quantity { get; set; }

    public decimal Calculate()
    {
        return Quantity * Product.Price;
    }
}