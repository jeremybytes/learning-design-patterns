using Microsoft.AspNetCore.Mvc;

namespace People.Service.Controllers;

[Route("[controller]")]
[ApiController]
public class PeopleController : ControllerBase
{
    private IPeopleProvider provider;

    public PeopleController(IPeopleProvider provider)
    {
        this.provider = provider;
    }

    [HttpGet]
    public Task<List<Person>> GetPeople()
    {
        return provider.GetPeople();
    }

    [HttpGet("{id}")]
    public Task<Person?> GetPerson(int id)
    {
        return provider.GetPerson(id);
    }

}
