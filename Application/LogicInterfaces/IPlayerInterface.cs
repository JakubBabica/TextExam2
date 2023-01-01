using Domain.DTOs;
using Domain.Models;

namespace Application.LogicInterfaces;

public interface IPlayerInterface
{
    Task<Player> CreateAsync(NewPlayerDTO newPlayerDto);
    Task DeleteAsync(int id);
}