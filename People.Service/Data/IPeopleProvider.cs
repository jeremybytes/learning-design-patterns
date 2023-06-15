using Shared;

namespace People.Service;

public interface IPeopleProvider
{
    Task<List<Person>> GetPeople();
}

