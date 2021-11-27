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
                optionsBuilder.UseSqlServer("Initial Catalog=Lavadero.NetCore; Data Source=DESKTOP-4AA1456; Integrated Security=true ");
                /* Initial Catalog: Nombre de la base de datos
                Data Source: NOmbre del Servidor de la Base de Datos
                Integrated Security: seguridad con la misma configuracion del inicio
                */
            
            }
        }
    }
}