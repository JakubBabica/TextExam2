using Application.LogicInterface;

namespace Application.Logic;

public class PLayerlogic:IPlayerLogic
{
    public Task<Player> CreateAsync(NewPlayerDto newPlayerDto)
    {
        throw new NotImplementedException();
    }
}