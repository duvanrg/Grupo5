using System.Reflection;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Data;

public class ApiContext : DbContext
{
    public ApiContext(DbContextOptions options) : base(options)
    {
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
        modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
    }
}