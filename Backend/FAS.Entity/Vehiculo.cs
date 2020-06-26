namespace FAS.Entity
{
    public class Vehiculo
    {
        public int Id {get;set;}
        public string placa {get;set;}
        public string nromotor {get;set;}
        public bool estadomotor {get;set;}
        public int IdModelo {get;set;}
        public Modelo Modelo {get;set;}
    }
}