using MenuFlow.API.Extensions;

var builder = WebApplication.CreateBuilder(args);

builder
    .AddArchitectures()
    .AddDependencies();

var app = builder.Build();

app.UseArchitectures();

app.Run();
