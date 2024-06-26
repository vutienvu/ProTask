using System.Reflection;
using Microsoft.EntityFrameworkCore;
using ProTask.Entity;

namespace ProTask.Helper;

public class DatabaseContext(DbContextOptions<DatabaseContext> contextOptions) : DbContext(contextOptions)
{
    public DbSet<Todo> Todos { get; set; } = null!;
    public DbSet<Programmer> Programmers { get; set; } = null!;
    public DbSet<Specialization> Specializations { get; set; } = null!;
    
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
        modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
    }
}