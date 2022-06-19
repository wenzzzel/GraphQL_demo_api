using GraphQL_demo_api.Data;
using GraphQL_demo_api.Models;

namespace GraphQL_demo_api.GraphQL.Drivers;

public class CarType : ObjectType<Car>
{
    protected override void Configure(IObjectTypeDescriptor<Car> descriptor)
    {
        descriptor.Description("The car field is pretty self explanatory.");
        descriptor.Field(c => c.DriverId).Description("This is a foreign key referring to the driverId in the drivers table");
    }

    public class Resolvers
    {

    }
}