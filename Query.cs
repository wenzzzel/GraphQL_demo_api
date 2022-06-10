using GraphQL_demo_api.Data;
using GraphQL_demo_api.Models;

namespace GraphQL_demo_api;

public class Query
{
    [UseDbContext(typeof(AppDbContext))]
    public IQueryable<Car> GetCar([ScopedService] AppDbContext context)
    {
        return context.Cars;
    }
}