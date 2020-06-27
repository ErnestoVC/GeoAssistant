using System.Collections.Generic;
using FAS.Entity;
using FAS.Repository.viewModel;

 
namespace FAS.Service
{
    public interface IViajeService : IService<Viaje>
    {
         IEnumerable<ViajeViewModel> GetAllViajes();
         IEnumerable<DetalleViajeViewModel> ListarDetalles(int viajeId);
    }
}