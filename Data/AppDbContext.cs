using GraphQL_demo_api.Models;
using Microsoft.EntityFrameworkCore;

namespace GraphQL_demo_api.Data;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions options) :base(options)
    {

    }

    public DbSet<Car> Cars { get; set; }
}