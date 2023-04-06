using System.Net.Http.Json;
using System.Text.Json;
using Domain.DTOs;
using Domain.Models;

namespace Blazor.Services.Http;

public class PlayerClient:IPlayerService
{
    private readonly HttpClient client;

    public PlayerClient(HttpClient httpClient)
    {
        this.client = httpClient;
    }
    public async Task<Player> CreateAsync(NewPlayerDTO dto)
    {
        HttpResponseMessage response = await client.PostAsJsonAsync("https://localhost:7264/Player", dto);
        string result = await response.Content.ReadAsStringAsync();
        if (!response.IsSuccessStatusCode)
        {
            throw new Exception(result);
        }
        Player player = JsonSerializer.Deserialize<Player>(result, new JsonSerializerOptions
        {
            PropertyNameCaseInsensitive = true
        })!;
        return player;
    }
}