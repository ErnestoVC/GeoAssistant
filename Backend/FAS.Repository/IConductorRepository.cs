using System.Collections;
using FAS.Entity;
 
namespace FAS.Repository
{
    public interface IConductorRepository : IRepository<Conductor>
    {
         IEnumerable fetchConductorByName(string nombre);
         IEnumerable fetchConductorbyDNI(string dni);
         IEnumerable fetchConductorByBrevete(string numero);
    }
}