using System.Collections;
using System.Collections.Generic;
using System.Linq;
using FAS.Entity;
using FAS.Repository.Context;
using Microsoft.EntityFrameworkCore;

namespace  FAS.Service.Implementacion
{
    public class CatBreveteServivce : ICatBreveteService
    {
        private ICatBreveteRespository  clRepos;
        
        public BreveteService(ICatBreveteRespository clRepos)
        {
            this.clRepos=clRepos;
        }

        public bool Save(CatBrevete e)
        {
            return clRepos.Save(e);
        }
        public bool Update(CatBrevete e)
        {
            return clRepos.Update(e);
        }

        public bool Delete(int id)
        {
            return clRepos.Delete(id);
        }
         
        public IEnumerable<CatBrevete> GetAll()
        {
            return clRepos.GetAll();
        }
         
        public CatBrevete Get(int id)
        {
            return clRepos.Get(id);
        }
    }
}