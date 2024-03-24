using Microsoft.Azure.CosmosRepository;

namespace WebApplication2;

public class User : Item
{
    public required string Name { get; set; }
}