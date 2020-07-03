using System.Collections.Generic;
using System;

namespace FAS.Repository.viewModel
{
    public class ViajeViewModel
    {
        public int Id {get;set;}
        public int nroViaje {get;set;}
        public double totalhoras {get;set;}
        public DateTime fechaviaje {get;set;}
        public string TipoCarga {get;set;}
        public int ConductorId {get;set;}
        public string NombreConductor {get;set;}
        public string brevete {get;set;}
        public int VehiculoID {get;set;}
        public string placa {get;set;}
        public string modelo {get;set;}
        public IEnumerable<DetalleViajeViewModel> DetalleViaje {get;set;}
    }
}