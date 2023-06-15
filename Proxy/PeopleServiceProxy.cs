using Shared;
using System.Net.Http;
using System.Text.Json;

namespace Proxy;

public class PeopleServiceProxy
{
    HttpClient client = new HttpClient();
    JsonSerializerOptions options = new() { PropertyNameCaseInsensitive = true };

    public PeopleServiceProxy()
    {
        client.BaseAddress = new Uri("http://localhost:9874");
    }

    public async Task<List<Person>> GetPeople()
    {
        HttpResponseMessage response = await client.GetAsync("people");
        if (!response.IsSuccessStatusCode)
        {
            throw new HttpRequestException($"Unable to process request. Status Code: {response.StatusCode}");
        }
        var stringResult = await response.Content.ReadAsStringAsync();
        return JsonSerializer.Deserialize<List<Person>>(stringResult, options)!;
    }

    public async Task<Person?> GetPerson(int id)
    {
        HttpResponseMessage response = await client.GetAsync($"people/{id}");
        if (!response.IsSuccessStatusCode)
        {
            throw new HttpRequestException($"Unable to process request. Status Code: {response.StatusCode}");
        }
        var stringResult = await response.Content.ReadAsStringAsync();
        return JsonSerializer.Deserialize<Person>(stringResult, options);
    }

}
