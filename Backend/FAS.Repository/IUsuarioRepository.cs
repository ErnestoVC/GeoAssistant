using System.Collections;
using FAS.Entity;
 
namespace FAS.Repository
{
    public interface IUsuarioRepository : IRepository<Usuarios>
    {
         IEnumerable fetchUsuariobyUsername (string username);         
    }
}