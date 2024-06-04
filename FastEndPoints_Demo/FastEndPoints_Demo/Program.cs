using FastEndpoints;
using FastEndpoints.Swagger;


var builder = WebApplication.CreateBuilder(args);

builder.Services
    .AddFastEndpoints()
    .SwaggerDocument();

var app = builder.Build();
app.UseFastEndpoints()
    .UseSwaggerGen()
    .UseSwaggerUI(c => {
        c.SwaggerEndpoint("/swagger/v1/swagger.json", "FastEndpoints Demo");
        c.RoutePrefix = string.Empty;
    });

app.Run();
