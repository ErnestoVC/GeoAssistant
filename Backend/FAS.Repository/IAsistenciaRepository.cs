using System;
using System.Collections;
using FAS.Entity;
 
namespace FAS.Repository
{
    public interface IAsistenciaRepository : IRepository<Asistencia>
    {
        IEnumerable fetchByDate (DateTime inicio, DateTime fin);
    }
}