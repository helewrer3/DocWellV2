using DocWellV2.Data;
using DocWellV2.Data.Models;
using Microsoft.EntityFrameworkCore;

namespace DocWellV2.Services;

public class PatientService(IDbContextFactory<AppDbContext> dbContextFactory)
{
    private readonly IDbContextFactory<AppDbContext> _dbContextFactory = dbContextFactory;

    public void AddPatient(Patient patient)
    {
        using var dbContext = _dbContextFactory.CreateDbContext();
        dbContext.Patients.Add(patient);
        dbContext.SaveChanges();
    }

    public List<Patient> GetPatientsByName(string name)
    {
        using var dbContext = _dbContextFactory.CreateDbContext();
        //PostgreSQL dependent
        var patients = dbContext.Patients.Where(p => EF.Functions.ILike(p.Name, $"%{name}%")).ToList();
        return patients;
    }
}