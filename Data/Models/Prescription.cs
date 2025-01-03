using System.ComponentModel.DataAnnotations;

namespace DocWellV2.Data.Models;

public class Prescription
{
    [Key]
    public int Id { get; set; }
    public string Diagnosis { get; set; }
    public string? Medicines { get; set; }
    public string? Note { get; set; }
    public DateTime CreatedDate { get; set; }
}