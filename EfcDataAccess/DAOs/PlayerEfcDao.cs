using Application.DAOInterfaces;
using Domain.Models;
using Microsoft.EntityFrameworkCore.ChangeTracking;

namespace EfcDataAccess.DAOs;

public class PlayerEfcDao:IPlayerDao
{
    private readonly Context Context;

    public PlayerEfcDao(Context context)
    {
        Context = context;
    }

    public async Task<Player> createAsync(Player player)
    {
        EntityEntry<Player> newPlayer = await Context.Players.AddAsync(player);
        await Context.SaveChangesAsync();
        return newPlayer.Entity;
    }
    public Task deleteAsync(int id)
    {
        foreach (Player player in Context.Players)
        {
            if (player.Id.Equals(id))
            {
                Context.Players.Remove(player); 
                Context.SaveChangesAsync();
            }
        }
        return Task.CompletedTask;
    }
}