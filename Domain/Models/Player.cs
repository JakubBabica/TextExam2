using System.ComponentModel.DataAnnotations;

namespace Domain.Models;

public class Player
{
    [Required]
    [MaxLength(50)]
    public string Name { get; set; }
    [Range(1, 99)]
    public int ShirtNo { get; set; }
    public decimal Salary { get; set; }
    [Key]
    public int Id { get; set; }
    public int GoalsThisSeason { get; set; }
    [Required]
    public string Position { get; set; }
    public string Teamname { get; set; }
    public Player(){}
}