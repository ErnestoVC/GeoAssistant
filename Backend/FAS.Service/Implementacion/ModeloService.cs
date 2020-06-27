using System.Collections;
using System.Collections.Generic;
using System.Linq;
using FAS.Entity;
using FAS.Repository.Context;
using Microsoft.EntityFrameworkCore;
using FAS.Repository;

namespace  FAS.Service.Implementacion
{
    public class ModeloServivce : IModeloService
    {
        private IModeloRepository  clRepos;
        
        public ModeloServivce(IModeloRepository clRepos)
        {
            this.clRepos=clRepos;
        }

        public bool Save(Modelo e)
        {
            return clRepos.Save(e);
        }
        public bool Update(Modelo e)
        {
            return clRepos.Update(e);
        }

        public bool Delete(int id)
        {
            return clRepos.Delete(id);
        }
         
        public IEnumerable<Modelo> GetAll()
        {
            return clRepos.GetAll();
        }
         
        public Modelo Get(int id)
        {
            return clRepos.Get(id);
        }
    }
}