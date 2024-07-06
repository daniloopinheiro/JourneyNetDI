public static class ScopedEndpoint
{
    public static void GetScopedEndpoint(this WebApplication app)
    {
        app.MapGet("api/scoped", () => 
        {
            var useCase = new ScopedUseCase();
            var response = useCase.Execute();
            return response; 
        })
        .WithName("GetScoped")
        .WithOpenApi();
    }
}