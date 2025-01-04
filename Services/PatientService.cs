using DocWellV2.Data;
using DocWellV2.Data.Models;
using Microsoft.EntityFrameworkCore;

namespace DocWellV2.Services;

public class PatientService(IDbContextFactory<AppDbContext> dbContextFactory)
{
    private readonly IDbContextFactory<AppDbContext> _dbContextFactory = dbContextFactory;

    public Patient AddPatient(Patient patient)
    {
        using var dbContext = _dbContextFactory.CreateDbContext();
        dbContext.Patients.Add(patient);
        dbContext.SaveChanges();
        return patient;
    }

    public List<Patient> GetPatientsByName(string name)
    {
        using var dbContext = _dbContextFactory.CreateDbContext();
        var patients = dbContext.Patients.Where(p => p.Name.ToLower().Contains(name.ToLower())).ToList();
        return patients;
    }

    public Patient? GetPatientById(int id)
    {
        using var dbContext = _dbContextFactory.CreateDbContext();
        var patient = dbContext.Patients.Find(id);
        return patient;
    }

    public Patient UpdatePatient(Patient patient)
    {
        using var dbContext = _dbContextFactory.CreateDbContext();
        dbContext.Attach(patient);
        dbContext.Entry(patient).State = EntityState.Modified;
        dbContext.SaveChanges();
        return patient;
    }
}