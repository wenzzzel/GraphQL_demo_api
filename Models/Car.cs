using System.ComponentModel.DataAnnotations;

namespace GraphQL_demo_api.Models;

public class Car
{
    [Key]
    public int Id { get; set; }
    [Required]
    public string Brand { get; set; }
    [Required]
    public string Name { get; set; }
    public string? Description { get; set; }
}