using GraphQL_demo_api;
using GraphQL_demo_api.Data;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddPooledDbContextFactory<AppDbContext>(
    opt => opt.UseSqlServer(builder.Configuration.GetConnectionString("AzureSql"))
);

builder.Services
    .AddGraphQLServer()
    .AddQueryType<Query>()
    .AddProjections();

var app = builder.Build();
app.MapGraphQL();

app.Run();
