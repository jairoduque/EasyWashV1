using System;
using System.Collections.Generic;

namespace EasyWash.App.Dominio
{
    public class Trabajador : Persona
    {
        public string Eps_trab {get; set;}
        public string Arl_trab { get; set;}
        public DateTime FechaIng_trab {get; set;}
        public DateTime FechaFin_trab {get; set;}
        public string Usu_trab {get; set;}
        public string Pass_trab {get; set;}
        public string Estado_trab {get; set;}
        public string Porcen_trab {get; set;}
        public Roles Roles {get; set;}
    }
}