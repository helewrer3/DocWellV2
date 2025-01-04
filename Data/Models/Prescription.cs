using System.ComponentModel.DataAnnotations;

namespace DocWellV2.Data.Models;

public class Prescription
{
    [Key]
    public int Id { get; set; }
    public string Diagnosis { get; set; }
    public string Medicines { get; set; } = string.Empty;
    public string Note { get; set; } = string.Empty;
    public DateTime CreatedDate { get; set; }
}