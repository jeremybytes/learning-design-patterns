using Microsoft.AspNetCore.Mvc;
using Shared;

namespace People.Service.Controllers;

[ApiController]
[Route("[controller]")]
public class PeopleController : ControllerBase
{
    private readonly IPeopleProvider _provider;

    public PeopleController(IPeopleProvider provider)
    {
        _provider = provider;
    }

    [HttpGet()]
    public Task<List<Person>> GetPeople()
    {
        return _provider.GetPeople();
    }

    [HttpGet("{id}")]
    public async Task<Person?> GetPerson(int id)
    {
        var people = await _provider.GetPeople();
        return people.FirstOrDefault(p => p.Id == id);
    }
}
