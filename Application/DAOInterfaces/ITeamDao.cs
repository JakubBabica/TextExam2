﻿using Domain;

namespace Application.DAOInterfaces;

public interface ITeamDao
{
    Task<Team> createAsync(Team team);
    public Task<IEnumerable<Team>> GetAsync();
}