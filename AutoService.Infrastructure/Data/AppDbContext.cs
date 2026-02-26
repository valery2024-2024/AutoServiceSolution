using Microsoft.EntityFrameworkCore;
using AutoService.Core.Entities;

namespace AutoService.Infrastructure.Data;

public class AppDbContext : DbContext
{
    public DbSet<Client> Clients { get; set; }
    public DbSet<Vehicle> Vehicles { get; set; }
    public DbSet<ServiceRequest> ServiceRequests { get; set; }

    public AppDbContext(DbContextOptions<AppDbContext> options)
        : base(options)
    {
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
    base.OnModelCreating(modelBuilder);

    // Vehicle to ServiceRequests (1:N)
    modelBuilder.Entity<Vehicle>()
        .HasMany(v => v.ServiceRequests)
        .WithOne(sr => sr.Vehicle)
        .HasForeignKey(sr => sr.VehicleId)
        .OnDelete(DeleteBehavior.Cascade);
    }
}