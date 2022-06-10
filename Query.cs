using GraphQL_demo_api.Data;
using GraphQL_demo_api.Models;

namespace GraphQL_demo_api;

public class Query
{
    [UseDbContext(typeof(AppDbContext))]
    [UseProjection]
    public IQueryable<Driver> GetDriver([ScopedService] AppDbContext context)
    {
        return context.Drivers;
    }

    [UseDbContext(typeof(AppDbContext))]
    [UseProjection]
    public IQueryable<Car> GetCar([ScopedService] AppDbContext context)
    {
        return context.Cars;
    }
}