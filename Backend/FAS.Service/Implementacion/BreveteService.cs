using System.Collections;
using System.Collections.Generic;
using System.Linq;
using FAS.Entity;
using FAS.Repository.Context;
using Microsoft.EntityFrameworkCore;

namespace  FAS.Service.Implementacion
{
    public class BreveteService : IBreveteService
    {
        private IBreveteRespository  clRepos;
        
        public BreveteService(IBreveteRespository clRepos)
        {
            this.clRepos=clRepos;
        }

        public bool Save(Brevete e)
        {
            return clRepos.Save(e);
        }
        public bool Update(Brevete e)
        {
            return clRepos.Update(e);
        }

        public bool Delete(int id)
        {
            return clRepos.Delete(id);
        }
         
        public IEnumerable<Brevete> GetAll()
        {
            return clRepos.GetAll();
        }
         
        public Brevete Get(int id)
        {
            return clRepos.Get(id);
        }
    }
}