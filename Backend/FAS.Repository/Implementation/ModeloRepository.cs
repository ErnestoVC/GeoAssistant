using System.Collections.Generic;
using System.Linq;
using FAS.Entity;
using FAS.Repository.Context;

namespace FAS.Repository.Implementation
{
    public class ModeloRepository : IModeloRepository
    {
        private ApplicationDbContext context;
        public ModeloRepository(ApplicationDbContext context){
            this.context=context;
        }
        public bool Delete(int id)
        {
            try
            {
                var result = new Modelo();
                result = context.Modelos.Single(x=>x.Id == id);
                context.Remove(result);
                context.SaveChanges();
            }
            catch (System.Exception)
            {
                
                return false;
            }
            return true;
        }

        public Modelo Get(int id)
        {                
            var result = new Modelo();
            try
            {
                result = context.Modelos.Single(x=>x.Id == id);
            }
            catch (System.Exception)
            {
                
                throw;
            }
            return result;
        }

        public IEnumerable<Modelo> GetAll()
        {
            var result = new List<Modelo>();
            try
            {
                result = context.Modelos.ToList();
            }
            catch (System.Exception)
            {
                
                throw;
            }
            return result;
        }

        public bool Save(Modelo e)
        {
            try
            {
                context.Add(e);
                context.SaveChanges();
            }
            catch (System.Exception)
            {
                
                return false;
            }
            return true;
        }

        public bool Update(Modelo e)
        {
            try
            {
                var origina = context.Modelos.Single(x=>x.Id == e.Id);
                origina.Id = e.Id;
                origina.modelo = e.modelo;
                origina.cargamax = e.cargamax;
                origina.nrollantas = e.nrollantas;

                context.Update(origina);
                context.SaveChanges();
            }
            catch (System.Exception)
            {
                
                return false;
            }
            return true;
        }
    }
}