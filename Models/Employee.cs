using System.ComponentModel.DataAnnotations;

public class Employee
{
    public int Id { get; set; }

    [Required(ErrorMessage = "Name is required")]
    public string? Name { get; set; }

    [Required(ErrorMessage = "Position is required")]
    public string? Position { get; set; }

    [Range(1, double.MaxValue, ErrorMessage = "Salary must be positive")]
    public decimal Salary { get; set; }
}
