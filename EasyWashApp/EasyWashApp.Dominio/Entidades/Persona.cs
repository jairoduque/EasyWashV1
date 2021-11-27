using System;
namespace EasyWashApp.Dominio
{
    public class Persona
    {
        public int Id {get; set;}
       //Tipo de Documentos
        public TipoDocumento TipoDocumento {get; set;}
        public string Numdoc_per {get; set;}
        public string Nom_per {get; set;}
        public DateTime Fechanac_per {get; set;}
        public int Edad_per {get; set;}
        public string Tel1_per {get; set;}
        public string Tel2_per {get; set;}
        public string Dir_per {get; set;}
        public string Email_per {get; set;}
    }
}