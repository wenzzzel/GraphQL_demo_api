using System.ComponentModel.DataAnnotations;

namespace GraphQL_demo_api.Models;

public class Driver
{
    [Key]
    public int Id { get; set; }
    [Required]
    public string Name { get; set; }
    public ICollection<Car> Cars { get; set; } = new List<Car>();
}