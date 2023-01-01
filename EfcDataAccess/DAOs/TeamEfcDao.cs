using Application.DAOInterfaces;
using Domain;
using Domain.Models;
using Microsoft.EntityFrameworkCore.ChangeTracking;

namespace EfcDataAccess.DAOs;

public class TeamEfcDao:ITeamDao
{
    private readonly Context Context;

    public TeamEfcDao(Context context)
    {
        Context = context;
    }  
    
    public async Task<Team> createAsync(Team team)
    {
        EntityEntry<Team> newTeam = await Context.Teams.AddAsync(team);
        await Context.SaveChangesAsync();
        return newTeam.Entity;
    }
}