using System.ComponentModel.DataAnnotations;

namespace DocWellV2.Data.Models;

public class Patient
{
    [Key]
    public int Id { get; set; }
    public string Name { get; set; }
    public double Weight { get; set; }
    public double Age { get; set; }
    public DateTime CreatedDate { get; set; }
}