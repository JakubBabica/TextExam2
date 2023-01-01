using Domain.Models;

namespace Application.DAOInterfaces;

public interface IPlayerDao
{
    Task<Player> createAsync(Player player);
}