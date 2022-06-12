using GraphQL_demo_api.Data;
using GraphQL_demo_api.Models;

namespace GraphQL_demo_api.GraphQL.Drivers;

public class DriverType : ObjectType<Driver>
{
    protected override void Configure(IObjectTypeDescriptor<Driver> descriptor)
    {
        descriptor.Description("The driver is the person registered as owner of the vehicle");

        descriptor.Field(d => d.Cars)
            .ResolveWith<Resolvers>(d => d.GetCar(default!, default!))
            .UseDbContext<AppDbContext>()
            .Description("This is a list of cars owned by this driver");
    }

    public class Resolvers
    {
        public IQueryable<Car> GetCar([Parent] Driver driver, [ScopedService] AppDbContext context)
        {
            return context.Cars.Where(c => c.DriverId == driver.Id);
        }
    }
}