using Domain.DTOs;
using Domain.Models;

namespace Blazor.Services;

public interface IPlayerService
{
    public Task<Player> CreateAsync(NewPlayerDTO dto);
}