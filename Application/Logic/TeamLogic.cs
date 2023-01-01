using Application.DAOInterfaces;
using Application.LogicInterfaces;
using Domain;
using Domain.DTOs;

namespace Application.Logic;

public class TeamLogic:ITeamLogic
{
    private readonly ITeamDao Dao;

    public TeamLogic(ITeamDao dao)
    {
        Dao = dao;
    }

    public async Task<Team> createAsync(NewTeamDTO dto)
    {
        Team toCreate = new Team
        {
            TeamName = dto.TeamName,
            NameOfCoach = dto.NameOfCoach,
            Ranking = dto.Ranking,
        };
        Team created = await Dao.createAsync(toCreate);
        return created;
    }

    public Task<IEnumerable<Team>> GetAsync()
    {
        return Dao.GetAsync();
    }
}