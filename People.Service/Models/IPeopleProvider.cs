namespace People.Service;

public interface IPeopleProvider
{
    Task<List<Person>> GetPeople();
    Task<Person?> GetPerson(int id);
}