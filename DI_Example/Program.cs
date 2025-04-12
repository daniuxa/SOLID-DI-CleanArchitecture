using DI_Example;
using DIP.Solution;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddScoped<IOrderRepository, OrderRepository>();
builder.Services.AddScoped<IRepository>(serviceProvider =>
{
    var useCache = Environment.GetEnvironmentVariable("USE_CACHE") == "true";
    return useCache
        ? serviceProvider.GetRequiredService<CacheRepository>()
        : serviceProvider.GetRequiredService<DatabaseRepository>();
});
 // Keyed Service implementation
// builder.Services.AddKeyedScoped<IRepository, CacheRepository>("cache");
// builder.Services.AddKeyedScoped<IRepository, DatabaseRepository>("db");


var app = builder.Build();

app.MapGet("order/{orderId}/price", (Guid orderId, IOrderRepository orderRepository) =>
    {
        orderRepository.GetPriceOfOrder(orderId);
    })
    .WithOpenApi();

app.Run();