using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using Programacion.net.Models;

public class AppDbContext : DbContext
{
    public DbSet<Cliente> Clientes { get; set; }
    public DbSet<Servicio> Servicios { get; set; }
    public DbSet<Cita> Citas { get; set; }

    public AppDbContext() : base("DefaultConnection") { }

 
}