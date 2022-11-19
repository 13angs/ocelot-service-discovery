var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/todo/{text}", (string text) => {
    return $"Todo: {text}";
});

app.Run();
