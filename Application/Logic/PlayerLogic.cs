
using Application.DAOInterfaces;
using Application.LogicInterfaces;
using Domain;
using Domain.DTOs;
using Application.LogicInterfaces;
using Domain.Models;

namespace Application.Logic;

public class PlayerLogic:IPlayerInterface
{
    private readonly IPlayerDao PlayerDao;

    public PlayerLogic(IPlayerDao playerDao)
    {
        PlayerDao = playerDao;
    }

    public async Task<Player> CreateAsync(NewPlayerDTO dto)
    {
        Player toCreate = new Player
        {
            Name = dto.Name,
            GoalsThisSeason = dto.GoalsThisSeason,
            Id = dto.Id,
            Position = dto.Position,
            Salary = dto.Salary,
            ShirtNo = dto.ShirtNo,
            Teamname =  dto.TeamName
        };
        Player created = await PlayerDao.createAsync(toCreate);
        return created;
    }
    public Task DeleteAsync(int id)
    {
        return PlayerDao.deleteAsync(id);
    }
}