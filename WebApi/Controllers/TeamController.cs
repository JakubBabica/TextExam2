using Application.LogicInterfaces;
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
    [HttpPost, Route("team")]
    public async Task<ActionResult> CreateAsync([FromBody] NewTeamDTO dto)
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
}