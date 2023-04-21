using Microsoft.Extensions.DependencyInjection;

class Program
{
    static void Main(string[] args)
    {
        // Create a new instance of the service collection
        var services = new ServiceCollection();

        // Register your service(s) here
        services.AddSingleton<MyService>();

        // Build the service provider
        var serviceProvider = services.BuildServiceProvider();

        // Resolve your service(s) here
        var myService = serviceProvider.GetService<MyService>();

        // Use your service(s) here
        myService.DoSomething();
    }
}