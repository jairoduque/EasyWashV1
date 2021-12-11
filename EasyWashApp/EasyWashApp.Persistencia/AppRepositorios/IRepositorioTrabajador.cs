using System.Collections.Generic;
using EasyWashApp.Dominio;

namespace EasyWashApp.Persistencia
{
    public interface IRepositorioTrabajador
    {
        IEnumerable<Trabajador> GetAllTrabajador();
        Trabajador AddTrabajador(Trabajador trabajador);
    }
}