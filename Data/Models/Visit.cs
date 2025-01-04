using System.ComponentModel.DataAnnotations;

namespace DocWellV2.Data.Models;

public class Visit
{
    [Key]
    public int Id { get; set; }
    public Patient Patient { get; set; }
    public Prescription Prescription { get; set; }
    public DateTime VisitDate { get; set; }
    public DateTime CreatedDate { get; set; }
}