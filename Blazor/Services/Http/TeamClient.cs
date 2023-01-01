using System.Net.Http.Json;
using System.Text.Json;
using Domain;
using Domain.DTOs;

namespace Blazor.Services.Http;

public class TeamClient:ITeamService
{
    private readonly HttpClient client;

    public TeamClient(HttpClient httpClient)
    {
        this.client = httpClient;
    }
    public async Task<Team> CreateAsync(NewTeamDTO dto)
    {
        HttpResponseMessage response = await client.PostAsJsonAsync("https://localhost:7264/Team", dto);
        string result = await response.Content.ReadAsStringAsync();
        if (!response.IsSuccessStatusCode)
        {
            throw new Exception(result);
        }
        Team team = JsonSerializer.Deserialize<Team>(result, new JsonSerializerOptions
        {
            PropertyNameCaseInsensitive = true
        })!;
        return team;
    }

    public async Task<IEnumerable<Team>> GetAll()
    {
        HttpResponseMessage response = await client.GetAsync("https://localhost:7264/Team");
        string result = await response.Content.ReadAsStringAsync();
        if (!response.IsSuccessStatusCode)
        {
            throw new Exception(result);
        }
        IEnumerable<Team> teams= JsonSerializer.Deserialize<IEnumerable<Team>>(result, new JsonSerializerOptions {
            PropertyNameCaseInsensitive = true
        })!;
        return teams;
    }
}