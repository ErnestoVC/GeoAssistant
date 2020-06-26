using System.Collections;
using FAS.Entity;
using FAS.Repository.viewModel;
 
namespace FAS.Repository
{
    public interface IViajeRepository : IRepository<Viaje>
    {
         IEnumerable<ViajeViewModel> GetAllViajes();
         IEnumerable<DetalleViajeViewModel> ListarDetalles();
    }
}