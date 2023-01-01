using Domain;
using Domain.DTOs;

namespace Application.LogicInterfaces;

public interface ITeamLogic
{
    Task<Team> createAsync(NewTeamDTO dto);
}