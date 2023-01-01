using Domain.Models;

namespace Domain.DTOs;

public class NewTeamDTO
{
    public string TeamName { get; set; }
    public string NameOfCoach { get; set; }
    public int Ranking { get; set; }
   // public List<Player> Players { get; set; }

    public NewTeamDTO(string teamName, string nameOfCoach, int ranking)
    {
        TeamName = teamName;
        NameOfCoach = nameOfCoach;
        Ranking = ranking;
       // Players = players;
    }
}