using DIP.Solution;

var databaseRepository = new DatabaseRepository();
var cacheRepository = new CacheRepository();

var orderRepository = new OrderRepository(databaseRepository);
orderRepository.Load(Guid.NewGuid());

orderRepository = new OrderRepository(cacheRepository);
orderRepository.Load(Guid.NewGuid());
