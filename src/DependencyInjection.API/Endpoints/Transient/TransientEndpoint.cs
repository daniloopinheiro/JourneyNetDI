public static class TransientEndpoint
{
    public static void GetTransientEndpoint(this WebApplication app)
    {
        app.MapGet("api/transient", () =>
        {
            var useCase = new TransientUseCase();
            var response = useCase.Execute();
            return response;
        })
        .WithName("GetTransient")
        .WithOpenApi();
    }
}