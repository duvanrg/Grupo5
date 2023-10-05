using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using Core.Entities;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Data;

public class Grupo5Context : DbContext
{
    public Grupo5Context(DbContextOptions<Grupo5Context> options) : base(options)
    {
    }
    public DbSet<Ciudad> Ciudades { get; set; }
    public DbSet<Departamento> Departamentos { get; set; }
    public DbSet<Matricula> Matriculas { get; set; }
    public DbSet<Pais> Paises { get; set; }
    public DbSet<Persona> Personas { get; set; }
    public DbSet<Salon> Salones { get; set; }
    public DbSet<TipoPersona> TipoPersonas { get; set; }
    public DbSet<TrainerSalon> TrainerSalones { get; set; }
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
        modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
    }
}
