using System;
using System.Collections.Generic;

namespace FAS.Entity
{
    public class Viaje
    {
        public int Id {get;set;}
        public int nroViaje {get;set;}
        public double Totalhoras {get;set;}
        public DateTime fechaviaje {get;set;}
        public string TipoCarga {get;set;}
        public int IdConductor {get;set;}
        public Conductor Conductor {get;set;}
        public int IdVehiculo {get;set;}
        public Vehiculo Vehiculo {get;set;}
        public IEnumerable<DetalleViaje> DetalleViaje {get;set;}

    }
}