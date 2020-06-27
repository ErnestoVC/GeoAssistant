using System.Collections.Generic;

namespace FAS.Service
{
    public interface IService<T>
    {
         bool Save (T e);
         bool Update (T e);
         bool Delete(int id);
         IEnumerable<T> GetAll();
         T Get(int id);
    }
}