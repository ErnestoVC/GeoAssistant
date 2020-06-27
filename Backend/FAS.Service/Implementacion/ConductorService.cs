using System.Collections;
using System.Collections.Generic;
using System.Linq;
using FAS.Entity;
using FAS.Repository.Context;
using Microsoft.EntityFrameworkCore;
using FAS.Repository;

namespace  FAS.Service.Implementacion
{
    public class ConductorServivce : IConductorService
    {
        private IConductorRepository  clRepos;
        
        public ConductorServivce(IConductorRepository clRepos)
        {
            this.clRepos=clRepos;
        }

        public bool Delete(int id)
        {
            return clRepos.Delete(id);
        }

        public IEnumerable fetchConductorByBrevete(string numero)
        {
            return clRepos.fetchConductorByBrevete(numero);
        }

        public IEnumerable fetchConductorbyDNI(string dni)
        {
            return clRepos.fetchConductorbyDNI(dni);
        }

        public IEnumerable fetchConductorByName(string nombre)
        {
            return clRepos.fetchConductorByName(nombre);
        }

        public Conductor Get(int id)
        {
            return clRepos.Get(id);
        }

        public IEnumerable<Conductor> GetAll()
        {
            return clRepos.GetAll();
        }

        public bool Save(Conductor e)
        {
            return clRepos.Save(e);
        }

        public bool Update(Conductor e)
        {
            return clRepos.Update(e);
        }
    }
}