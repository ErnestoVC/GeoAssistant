using System.Collections;
using FAS.Entity;
 
namespace FAS.Repository
{
    public interface IVehiculoRepository : IRepository<Vehiculo>
    {
         IEnumerable fetchVehiculobyPlaca (string placa);
    }
}