using Application.LogicInterfaces;
using Domain.DTOs;
using Domain.Models;
using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers;
[ApiController]
[Route("[controller]")]
public class PlayerController:ControllerBase
{
    private readonly IPlayerInterface Logic;

    public PlayerController(IPlayerInterface logic)
    {
        Logic = logic;
    }
    [HttpPost]
    public async Task<ActionResult> CreateAsync( NewPlayerDTO dto)
    {
        try
        {
            Console.WriteLine("hsh");
            Player player = await Logic.CreateAsync(dto);
            return Ok(player);
        }
        catch (Exception e)
        {
            return BadRequest(e.Message);
        }
    }
    [HttpDelete("{id:int}")]
    public async Task<ActionResult<IEnumerable<Player>>> deleteAsync([FromRoute]int id)
    {
        try
        {
            await Logic.DeleteAsync(id);
            return Ok();
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            return StatusCode(500, e.Message);
        }
    }
}