
using Domain;
using Domain.DTOs;

namespace Blazor.Services;

public interface ITeamService
{
    public Task<Team> CreateAsync(NewTeamDTO dto);
    Task<IEnumerable<Team>> GetAll();
}