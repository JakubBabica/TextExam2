using System.ComponentModel.DataAnnotations;

namespace Domain.Models;

public class Team
{
    [Key]
    public string TeamName { get; set; }
    [Required]
    [MaxLength(50)]
    public string NameOfCoach { get; set; }
    public int Ranking { get; set; }
    public List<Player> Players { get; set; }
    public Team(){}
}