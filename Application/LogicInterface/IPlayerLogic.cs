namespace Application.LogicInterface;

public interface IPlayerLogic
{
    Task<Player> CreateAsync(NewPlayerDto newPlayerDto);
}