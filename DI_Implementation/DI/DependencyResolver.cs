namespace DI_Implementation.DI;

public class DependencyResolver
{
    private readonly DependencyContainer _container;
    public DependencyResolver(DependencyContainer container)
    {
        _container = container;
    }

    public T GetService<T>()
    {
        return (T)GetService(typeof(T));
    }

    private object GetService(Type type)
    {
        var dependency = _container.GetDependency(type);
        var constructor = dependency.Type.GetConstructors().Single();
        var parameters = constructor.GetParameters().ToArray();

        if (parameters.Length == 0)
            return CreateImplementation(dependency, t => Activator.CreateInstance(t));

        var parameterImplementations = new object[parameters.Length];

        for (int i = 0; i < parameters.Length; i++)
        {
            parameterImplementations[i] = GetService(parameters[i].ParameterType);
        }

        return CreateImplementation(dependency, t => Activator.CreateInstance(t, parameterImplementations));
    }

    private object CreateImplementation(Dependency dependency, Func<Type, object> factory)
    {
        if (dependency.Implemented)
        {
            return dependency.Implementation;
        }

        var implementation = factory(dependency.Type);

        if (dependency.Lifetime == DependencyLifetime.Singleton)
        {
            dependency.AddImplementation(implementation);
        }

        return implementation;
    }
}