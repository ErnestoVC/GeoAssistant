using System.Collections;
using System.Collections.Generic;
using System.Linq;
using FAS.Entity;
using FAS.Repository.Context;
using Microsoft.EntityFrameworkCore;
using FAS.Repository;

namespace  FAS.Service.Implementacion
{
    public class VehiculoServivce : IVehiculoService
    {
        private IVehiculoRepository  clRepos;
        
        public VehiculoServivce(IVehiculoRepository clRepos)
        {
            this.clRepos=clRepos;
        }

        public bool Delete(int id)
        {
            return clRepos.Delete(id);
        }

        public IEnumerable fetchVehiculobyPlaca(string placa)
        {
            return clRepos.fetchVehiculobyPlaca(placa);
        }

        public Vehiculo Get(int id)
        {
            return clRepos.Get(id);
        }

        public IEnumerable<Vehiculo> GetAll()
        {
            return clRepos.GetAll();
        }

        public bool Save(Vehiculo e)
        {
            return clRepos.Save(e);
        }

        public bool Update(Vehiculo e)
        {
            return clRepos.Update(e);
        }
    }
}