using DocWellV2.Data;
using DocWellV2.Data.Models;
using Microsoft.EntityFrameworkCore;

namespace DocWellV2.Services;

public class VisitService(IDbContextFactory<AppDbContext> dbContextFactory)
{
    private readonly IDbContextFactory<AppDbContext> _dbContextFactory = dbContextFactory;

    public Visit AddVisit(Visit visit)
    {
        using var dbContext = _dbContextFactory.CreateDbContext();
        dbContext.Attach(visit.Patient);
        dbContext.Attach(visit.Prescription);
        dbContext.Visits.Add(visit);
        dbContext.SaveChanges();
        return visit;
    }
}