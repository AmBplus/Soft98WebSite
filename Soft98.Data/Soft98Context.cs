using Microsoft.EntityFrameworkCore;
using Soft98.Data.Map;
using Soft98.Domain;

namespace Soft98.Data;

public class Soft98Context : DbContext
{
    public Soft98Context(DbContextOptions<Soft98Context> options) : base(options)
    {
    }
    public DbSet<User> Users { get; set; }
    public DbSet<Role> Roles { get; set; }
    public DbSet<UserRole> UserRoles { get; set; }
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        var assembly = typeof(MapUser).Assembly;
        modelBuilder.ApplyConfigurationsFromAssembly(assembly);
        //modelBuilder.ApplyConfiguration(new MapRole());
        //modelBuilder.ApplyConfiguration(new MapUser());
        //modelBuilder.ApplyConfiguration(new MapUserRole());
        base.OnModelCreating(modelBuilder);
    }
}