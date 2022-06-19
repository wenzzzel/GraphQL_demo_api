using GraphQL_demo_api.GraphQL;
using GraphQL_demo_api.Data;
using GraphQL_demo_api.GraphQL.Drivers;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddPooledDbContextFactory<AppDbContext>(
    opt => opt.UseSqlServer(builder.Configuration.GetConnectionString("AzureSql"))
);

builder.Services
    .AddGraphQLServer()
    .AddQueryType<Query>()
    .AddMutationType<Mutation>()
    .AddType<DriverType>()
    .AddType<CarType>()
    .AddProjections();

var app = builder.Build();
app.MapGraphQL();

app.Run();
