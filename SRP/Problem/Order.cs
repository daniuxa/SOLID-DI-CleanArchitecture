namespace SRP.Problem;

public class Order
{
    public Guid Id { get; set; }
    
    public List<OrderItems> OrderItemsList { get; set; }

    public Order()
    {
        OrderItemsList = new List<OrderItems>();
    }
    
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

    public void Load()
    {
        var dbRepo = new DatabaseRepository();
        OrderItemsList = dbRepo.Load(Id).ToList();
    }

    public void Save()
    {
        var dbRepo = new DatabaseRepository();
        dbRepo.Save(Id, OrderItemsList);
    }

    public void Print()
    {
        var fileWriter = new FileWriter();
        fileWriter.FileWrite(Id, OrderItemsList);
    }
}