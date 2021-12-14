using System;
using System.Collections.Generic;
using EasyWashApp.Dominio;
using EasyWashApp.Persistencia;

namespace EasyWashApp.Consola
{
    class Program
    {
        private static IRepositorioTrabajador _repoTrabajador = new RepositorioTrabajador();

        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            //AddTrabajador();
            MostrarTrabajador();
        }
        private static void AddTrabajador(){
            var trabajador = new Trabajador{
                TipoDocumento = TipoDocumento.Pasaporte,
                Numdoc_per = "1060650022",
                Nom_per = "Pepito Perez",
                Fechanac_per = new DateTime (1990,10,11),
                Edad_per = 31,
                Tel1_per = "3137354242",
                Tel2_per = "3136174301",
                Dir_per = "Av. Santander",
                Email_per ="prueba@gmail.com",
                Eps_trab = "Nueva EPS",
                Arl_trab = "Positiva",
                FechaIng_trab = new DateTime (2020,09,27),
                FechaFin_trab = new DateTime (),
                Usu_trab = "jduque",
                Pass_trab = "1234",
                Estado_trab = "Activo",
                Porcen_trab = "10",
                Roles = Roles.Administrador
            };
            _repoTrabajador.AddTrabajador(trabajador);
        }
        private static void MostrarTrabajador(){
            IEnumerable<Trabajador> trabajadores = _repoTrabajador.GetAllTrabajador();
            foreach (var trabajador in trabajadores){
                Console.WriteLine(trabajador.Nom_per);
            }
        }
        /**private static void BuscarTrabajador(int idTrabajador)
        {
            var trabajador = _repoTrabajdor.GetTrabajaor(idTrabajdor);
            Console.WriteLine(trabajador.Nom_trab);
        }
        private static void EliminarTrabajador(int idTrabajador)
        {
            _repoTrabajador.DeleteTrabajador(idTrabajador);
            Console.WriteLine("Trabajador Eliminado");
        } **/
    }
}
