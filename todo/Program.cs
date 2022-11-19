using Consul.Client;

var builder = WebApplication.CreateBuilder(args);

var consulConfig = builder.Configuration.GetConsulConfig();
builder.Services.RegisterConsulServices(consulConfig);

var app = builder.Build();

app.MapGet("/todo/{text}", (string text) => {
    return $"Todo: {text}";
});

app.Run();
