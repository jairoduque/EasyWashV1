using System.Collections.Generic;
using EasyWashApp.Dominio;

namespace EasyWashApp.Persistencia
{
    public interface IRepositorioTrabajador
    {
        IEnumerable<Trabajador> GetAllTrabajador();
        Trabajador AddTrabajador(Trabajador trabajador);
        ///Trabajador UpdateTrabajador(Trabajador trabajador);
        ///void DeleteTrabajador(int idTrabajador);
        ///Trabajador GetTrabajador(Trabajador idTrabajador);
    }
}