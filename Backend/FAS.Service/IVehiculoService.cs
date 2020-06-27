using System.Collections;
using FAS.Entity;
 
namespace FAS.Service
{
    public interface IVehiculoService : IService<Vehiculo>
    {
         IEnumerable fetchVehiculobyPlaca (string placa);
    }
}