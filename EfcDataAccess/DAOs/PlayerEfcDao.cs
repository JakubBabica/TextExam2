using Application.DAOInterfaces;
using Domain.Models;

namespace EfcDataAccess.DAOs;

public class PlayerEfcDao:IPlayerDao
{
    public Task<Player> createAsync(Player player)
    {
        throw new NotImplementedException();
    }
}