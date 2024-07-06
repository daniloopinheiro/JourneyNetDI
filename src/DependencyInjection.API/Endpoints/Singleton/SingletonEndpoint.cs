namespace DependencyInjection.API.Endpoints.Singleton;
public static class SingletonEndpoint
{
    public static void GetSingletonEndpoint(this WebApplication app)
    {
        app.MapGet("api/singleton", () => 
        {
            var useCase = new SingletonUseCase();
            var response = useCase.Execute();
            return response;
        })
        .WithName("GetSingleton")
        .WithOpenApi();
    }
}