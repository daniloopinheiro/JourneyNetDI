using DependencyInjection.API.Endpoints.Scoped;
using DependencyInjection.API.Endpoints.Transient;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddScoped<ScopedUseCase>();
builder.Services.AddSingleton<SingletonUseCase>();
builder.Services.AddTransient<TransientUseCase>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

// app.GetWeatherForecastEndpoint();
app.GetScopedEndpoint();
app.GetSingletonEndpoint();
app.GetTransientEndpoint();

app.UseHttpsRedirection();

app.Run();