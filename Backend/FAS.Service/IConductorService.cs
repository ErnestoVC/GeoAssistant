using System.Collections;
using FAS.Entity;
 
namespace FAS.Service
{
    public interface IConductorService : IService<Conductor>
    {
         IEnumerable fetchConductorByName(string nombre);
         IEnumerable fetchConductorbyDNI(string dni);
         IEnumerable fetchConductorByBrevete(string numero);
    }
}