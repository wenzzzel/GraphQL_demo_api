using GraphQL_demo_api.Data;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDbContext<AppDbContext>(
    opt => opt.UseSqlServer(builder.Configuration.GetConnectionString("AzureSql"))
);

var app = builder.Build();
app.MapGet("/", () => "Hello World!");

app.Run();
