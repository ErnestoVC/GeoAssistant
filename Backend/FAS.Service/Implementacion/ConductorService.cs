using System.Collections;
using System.Collections.Generic;
using System.Linq;
using FAS.Entity;
using FAS.Repository.Context;
using Microsoft.EntityFrameworkCore;

namespace  FAS.Service.Implementacion
{
    public class ConductorServivce : IConductorService
    {
        private IConductorRespository  clRepos;
        
        public BreveteService(IConductorRespository clRepos)
        {
            this.clRepos=clRepos;
        }

        public bool Save(Conductor e)
        {
            return clRepos.Save(e);
        }
        public bool Update(Conductor e)
        {
            return clRepos.Update(e);
        }

        public bool Delete(int id)
        {
            return clRepos.Delete(id);
        }
         
        public IEnumerable<Conductor> GetAll()
        {
            return clRepos.GetAll();
        }
         
        public Conductor Get(int id)
        {
            return clRepos.Get(id);
        }
    }
}