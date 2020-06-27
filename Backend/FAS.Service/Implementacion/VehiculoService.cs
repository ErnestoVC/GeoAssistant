using System.Collections;
using System.Collections.Generic;
using System.Linq;
using FAS.Entity;
using FAS.Repository.Context;
using Microsoft.EntityFrameworkCore;

namespace  FAS.Service.Implementacion
{
    public class VehiculoServivce : IVehiculoService
    {
        private IVehiculoRespository  clRepos;
        
        public BreveteService(IVehiculoRespository clRepos)
        {
            this.clRepos=clRepos;
        }

        public bool Save(Vehiculo e)
        {
            return clRepos.Save(e);
        }
        public bool Update(Vehiculo e)
        {
            return clRepos.Update(e);
        }

        public bool Delete(int id)
        {
            return clRepos.Delete(id);
        }
         
        public IEnumerable<Vehiculo> GetAll()
        {
            return clRepos.GetAll();
        }
         
        public Vehiculo Get(int id)
        {
            return clRepos.Get(id);
        }
    }
}