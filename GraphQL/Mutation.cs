using GraphQL_demo_api.Data;
using GraphQL_demo_api.GraphQL.Drivers;
using GraphQL_demo_api.Models;

namespace GraphQL_demo_api.GraphQL;

public class Mutation
{
    [UseDbContext(typeof(AppDbContext))]
    public async Task<AddDriverPayload> AddDriverAsync(AddDriverInput input, [ScopedService] AppDbContext context)
    {
        var driver = new Driver{
            Name = input.Name
        };

        context.Drivers.Add(driver);
        await context.SaveChangesAsync();

        return new AddDriverPayload(driver);
    }
}