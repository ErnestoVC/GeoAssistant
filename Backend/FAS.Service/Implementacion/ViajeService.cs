using System.Collections;
using System.Collections.Generic;
using System.Linq;
using FAS.Entity;
using FAS.Repository.Context;
using Microsoft.EntityFrameworkCore;

namespace  FAS.Service.Implementacion
{
    public class ViajeServivce : IViajeService
    {
        private IViajeRespository  clRepos;
        
        public BreveteService(IViajeRespository clRepos)
        {
            this.clRepos=clRepos;
        }

        public bool Save(Viaje e)
        {
            return clRepos.Save(e);
        }
        public bool Update(Viaje e)
        {
            return clRepos.Update(e);
        }

        public bool Delete(int id)
        {
            return clRepos.Delete(id);
        }
         
        public IEnumerable<Viaje> GetAll()
        {
            return clRepos.GetAll();
        }
         
        public Viaje Get(int id)
        {
            return clRepos.Get(id);
        }
    }
}