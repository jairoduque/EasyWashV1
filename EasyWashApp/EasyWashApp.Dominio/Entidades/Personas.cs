using System;
namespace EasyWashApp.Domminio
{
    public class Personas{
        //Identificador unico de cada Persona
        public int Id {get; set;}
        public TipoDocumentos TipoDocumento {get; set;}
        public string NumDoc_per {get; set;}
        public string Nom_per {get; set;}
        public Date Fechanac_per {get; set;}
        public int Edad_per {get; set;}
        public string Tel1 {get; set;}
        public string Tel2 {get; set;}
        public string Dir_per {get; set;}
        public string Email_per {get; set;}
    }
}