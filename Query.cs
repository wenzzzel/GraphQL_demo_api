using GraphQL_demo_api.Data;
using GraphQL_demo_api.Models;

namespace GraphQL_demo_api;

public class Query
{
    public IQueryable<Car> GetCar([Service] AppDbContext context)
    {
        return context.Cars;
    }
}