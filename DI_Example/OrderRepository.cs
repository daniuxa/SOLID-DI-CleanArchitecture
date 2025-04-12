namespace DI_Example;

public class OrderRepository : IOrderRepository
{
    private readonly IRepository _repository;

    public OrderRepository(IRepository repository)
    {
        _repository = repository ?? throw new ArgumentNullException(nameof(repository));
    }

    public IEnumerable<Product> GetAllProductsInOrder(Guid orderId)
    {
        return _repository.Load(orderId).Select(x => x.Product);
    }
    
    public decimal GetPriceOfOrder(Guid orderId)
    {
        return _repository.Load(orderId).Sum(x => x.Calculate());
    }

    public void SaveOrders(Order order)
    {
        _repository.Save(order.Id, order.OrderItemsList);
    }
}

// Keyed Service implementation
// public class OrderRepository : IOrderRepository
// {
//     private readonly IRepository _dbRepository;
//     private readonly IRepository _cacheRepository;
//
//     public OrderRepository([FromKeyedServices("db")]IRepository dbRepository,
//         [FromKeyedServices("cache")]IRepository cacheRepository, IConfiguration configuration)
//     {
//         _dbRepository = dbRepository ?? throw new ArgumentNullException(nameof(dbRepository));
//         _cacheRepository = cacheRepository ?? throw new ArgumentNullException(nameof(cacheRepository));
//     }
//
//     public IEnumerable<Product> GetAllProductsInOrder(Guid orderId)
//     {
//         return GetRepository().Load(orderId).Select(x => x.Product);
//     }
//     
//     public decimal GetPriceOfOrder(Guid orderId)
//     {
//         return GetRepository().Load(orderId).Sum(x => x.Calculate());
//     }
//
//     public void SaveOrders(Order order)
//     {
//         GetRepository().Save(order.Id, order.OrderItemsList);
//     }
//
//     private IRepository GetRepository()
//     {
//         return Environment.GetEnvironmentVariable("USE_CACHE") == "true" ? _cacheRepository : _dbRepository;
//     }
// }