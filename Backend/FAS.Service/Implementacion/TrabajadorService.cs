using System.Collections;
using System.Collections.Generic;
using System.Linq;
using FAS.Entity;
using FAS.Repository.Context;
using Microsoft.EntityFrameworkCore;

namespace  FAS.Service.Implementacion
{
    public class TrabajadorServivce : ITrabajadorService
    {
        private ITrabajadorRespository  clRepos;
        
        public BreveteService(ITrabajadorRespository clRepos)
        {
            this.clRepos=clRepos;
        }

        public bool Save(Trabajador e)
        {
            return clRepos.Save(e);
        }
        public bool Update(Trabajador e)
        {
            return clRepos.Update(e);
        }

        public bool Delete(int id)
        {
            return clRepos.Delete(id);
        }
         
        public IEnumerable<Trabajador> GetAll()
        {
            return clRepos.GetAll();
        }
         
        public Trabajador Get(int id)
        {
            return clRepos.Get(id);
        }
    }
}