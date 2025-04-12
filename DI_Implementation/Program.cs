using DI_Implementation;
using DI_Implementation.DI;

var container = new DependencyContainer();
container.AddTransient<ServiceConsumer>();
container.AddTransient<HelloService>();
container.AddSingleton<MessageService>();

var resolver = new DependencyResolver(container);

var service1 = resolver.GetService<ServiceConsumer>();

service1.Print();
var service2 = resolver.GetService<ServiceConsumer>();
service2.Print();
var service3 = resolver.GetService<ServiceConsumer>();
service3.Print();