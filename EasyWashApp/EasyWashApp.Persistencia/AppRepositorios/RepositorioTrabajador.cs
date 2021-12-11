using System.Collections.Generic;
using System.Linq;
using EasyWashApp.Dominio;
using Microsoft.EntityFrameworkCore;

namespace EasyWashApp.Persistencia
{
    public class RepositorioTrabajador : IRepositorioTrabajador
    {
        private readonly AppContext _appContext = new AppContext();

        Trabajador IRepositorioTrabajador.AddTrabajador(Trabajador trabajador){
            var trabajadorAdicionado = _appContext.Trabajador.Add(trabajador);
            _appContext.SaveChanges();
            return trabajadorAdicionado.Entity;
        }
        IEnumerable<Trabajador> IRepositorioTrabajador.GetAllTrabajador(){
            return _appContext.Trabajador;
        }
    }
}