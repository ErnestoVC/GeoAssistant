using FAS.Entity;
using Microsoft.EntityFrameworkCore;

namespace FAS.Repository.Context
{
    public class ApplicationDbContext: DbContext
    {
        public DbSet<Asistencia> Asistencias {get;set;}
        public DbSet<Brevete> Brevetes {get;set;}
        public DbSet<CatBrevete> CatBrevetes {get;set;}
        public DbSet<Conductor> Conductores {get;set;}
        public DbSet<DetalleViaje> DetalleViajes {get;set;}
        public DbSet<Trabajador> Trabajadores {get;set;}
        public DbSet<Usuarios> Usuarios {get;set;}
        public DbSet<Modelo> Modelos {get;set;}
        public DbSet<Vehiculo> Vehiculos {get;set;}
        public DbSet<Viaje> Viajes {get;set;}

        public ApplicationDbContext (DbContextOptions<ApplicationDbContext> options) : base (options) {

        }
    }
}