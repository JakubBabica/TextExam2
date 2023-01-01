namespace Domain.DTOs;

public class NewPlayerDTO
{
    public string Name { get; set; }
    public int ShirtNo { get; set; }
    public decimal Salary { get; set; }
    public int Id { get; set; }
    public int GoalsThisSeason { get; set; }
    public string Position { get; set; }
    public string TeamName { get; set; }
    public NewPlayerDTO(string name, int shirtNo, decimal salary, int id, int goalsThisSeason, string position,string teamName)
    {
        Name = name;
        ShirtNo = shirtNo;
        Salary = salary;
        Id = id;
        GoalsThisSeason = goalsThisSeason;
        Position = position;
        TeamName = teamName;
    }
}