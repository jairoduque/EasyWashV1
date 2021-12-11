using Microsoft.EntityFrameworkCore;
using EasyWashApp.Dominio;
namespace EasyWashApp.Persistencia
{
    public class AppContext : DbContext
    {
        /*Llamamos a las librerias para crearlas en la BD */
        public DbSet<Persona> Persona {get; set;}
        public DbSet<Trabajador> Trabajador {get; set;}

        protected override void OnConfiguring (DbContextOptionsBuilder optionsBuilder){
            if(!optionsBuilder.IsConfigured){
                optionsBuilder.UseSqlServer("Initial Catalog=LavaderoNet; Data Source=DESKTOP-4AA1456\\SQLEXPRESS; Integrated Security=true");
            }
        }
    }
}