namespace FAS.Entity
{
    public class Conductor
    {
        public int Id {get;set;}
        public int IdBrevete {get;set;}
        public Brevete Brevete {get;set;}
        public int IdTrabajador {get;set;}
        public Trabajador Trabajador {get;set;}
    }
}