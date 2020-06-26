namespace FAS.Entity
{
    public class Trabajador
    {
        public int Id {get;set;}
        public string Nombres {get;set;}
        public string Apellidos {get;set;}
        public string DNI {get;set;}
        public string Correo {get;set;}
        public string Celular {get;set;}
        public int IdUsuario {get;set;}
        public Usuarios Usuario {get;set;}
    }
}