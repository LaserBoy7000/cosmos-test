using Microsoft.AspNetCore.Mvc;
using Microsoft.Azure.CosmosRepository;
using Microsoft.Azure.CosmosRepository.Specification;

namespace WebApplication2.Controllers;
[ApiController]
[Route("user")]
public class UsersController(IRepository<User> users) : ControllerBase
{
    private readonly IRepository<User> _users = users;

    [HttpGet("list")]
    public async Task<IEnumerable<User>> Get() => await _users.GetAsync(x => true);

    [HttpGet("create")]
    public async Task<User> Generate()
    {
        var user = new User { Name = NameMockData.GenerateRandomName() };
        await _users.CreateAsync(user);
        return user;
    }
}
