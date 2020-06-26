namespace FAS.Entity
{
    public class DetalleViaje
    {
        public int Id {get;set;}
        public int IdViaje {get;set;}
        public Viaje Viaje {get;set;}
        public int IdAsistencia {get;set;}
        public Asistencia Asistencia {get;set;}
    }
}