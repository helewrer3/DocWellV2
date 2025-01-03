using DocWellV2.Data.Models;
using Microsoft.EntityFrameworkCore;

namespace DocWellV2.Data;

public class AppDbContext(DbContextOptions<AppDbContext> options) : DbContext(options)
{
    public DbSet<Patient> Patients { get; set; }
    public DbSet<Visit> Visits { get; set; }
    public DbSet<Prescription> Prescriptions { get; set; }
    
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Patient>()
            .HasIndex(p => new { p.Name })
            .IsUnique(true);
    }
}