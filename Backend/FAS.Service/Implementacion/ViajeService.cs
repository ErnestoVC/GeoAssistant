using System.Collections;
using System.Collections.Generic;
using System.Linq;
using FAS.Repository.Context;
using FAS.Repository.viewModel;
using Microsoft.EntityFrameworkCore;
using FAS.Repository;
using FAS.Entity;

namespace  FAS.Service.Implementacion
{
    public class ViajeServivce : IViajeService
    {
        private IViajeRepository  clRepos;
        
        public ViajeServivce(IViajeRepository clRepos)
        {
            this.clRepos=clRepos;
        }

        public bool Delete(int id)
        {
            return clRepos.Delete(id);
        }

        public Viaje Get(int id)
        {
            return clRepos.Get(id);
        }

        public IEnumerable<Viaje> GetAll()
        {
            return clRepos.GetAll();
        }

        public IEnumerable<ViajeViewModel> GetAllViajes()
        {
            return clRepos.GetAllViajes();
        }

        public IEnumerable<DetalleViajeViewModel> ListarDetalles(int viajeId)
        {
            return clRepos.ListarDetalles(viajeId);
        }

        public bool Save(Viaje e)
        {
            return clRepos.Save(e);
        }

        public bool Update(Viaje e)
        {
            return clRepos.Update(e);
        }
    }
}