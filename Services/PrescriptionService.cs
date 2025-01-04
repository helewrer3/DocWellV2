using DocWellV2.Data;
using DocWellV2.Data.Models;
using DocWellV2.Utils;
using Microsoft.EntityFrameworkCore;

namespace DocWellV2.Services;

public class PrescriptionService(IDbContextFactory<AppDbContext> dbContextFactory)
{
    private readonly IDbContextFactory<AppDbContext> _dbContextFactory = dbContextFactory;

    public Prescription AddPrescription(string diagnosis, List<Medicine> medicines, string note)
    {
        var prescription = new Prescription
        {
            Diagnosis = diagnosis,
            Note = note,
            Medicines = NewVisit.SerializeMedicines(medicines),
            CreatedDate = DateTime.UtcNow
        };
        using var dbContext = _dbContextFactory.CreateDbContext();
        dbContext.Prescriptions.Add(prescription);
        dbContext.SaveChanges();
        return prescription;
    }
    
}