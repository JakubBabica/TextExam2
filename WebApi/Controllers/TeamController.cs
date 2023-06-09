﻿using Application.LogicInterfaces;
using Domain;
using Domain.DTOs;
using Domain.Models;
using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers;
[ApiController]
[Route("[controller]")]
public class TeamController:ControllerBase
{
    private readonly ITeamLogic Logic;

    public TeamController(ITeamLogic logic)
    {
        Logic = logic;
    }
    [HttpPost]
    public async Task<ActionResult> CreateAsync(NewTeamDTO dto)
    {
        try
        {
            Team team = await Logic.createAsync(dto);
            return Ok(team);
        }
        catch (Exception e)
        {
            return BadRequest(e.Message);
        }
    }
    [HttpGet]
    public async Task<ActionResult<IEnumerable<Team>>> GetAsync()
    {
        try
        {
            IEnumerable<Team> teams = await Logic.GetAsync();
            return Ok(teams);
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            return StatusCode(500, e.Message);
        }
    }
}