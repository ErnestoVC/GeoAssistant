using System.Collections;
using System.Collections.Generic;
using System.Linq;
using FAS.Entity;
using FAS.Repository.Context;
using Microsoft.EntityFrameworkCore;

namespace FAS.Repository.Implementation
{
    public class BreveteRepository : IBreveteRepository
    {
        private ApplicationDbContext context;

        public BreveteRepository(ApplicationDbContext context){
            this.context=context;
        }

        public bool Save (Brevete e){
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
        public bool Update (Brevete e){
            try
            {
                var origen = context.Brevetes.Single(x=>x.Id == e.Id);
                origen.Id = e.Id;
                origen.numero = e.numero;
                origen.fechaExpi = e.fechaExpi;
                origen.IdcatBrevete = e.IdcatBrevete;

                context.Update(origen);
                context.SaveChanges();
            }
            catch (System.Exception)
            {
                
                return false;
            }
            return true;
        }
        public bool Delete(int id){
            try
            {
                var result = new Brevete();
                result = context.Brevetes.Single(x=>x.Id == id);
                context.Remove(result);
                context.SaveChanges();
            }
            catch (System.Exception)
            {
                
                return false;
            }
            return true;            
        }
        public IEnumerable<Brevete> GetAll(){
            var result = new List<Brevete>();
            try{
                result = context.Brevetes.Include(c=>c.CatBrevete).ToList();
                result.Select(c=> new Brevete{
                    Id = c.Id,
                    numero = c.numero,
                    fechaExpi = c.fechaExpi,
                    IdcatBrevete = c.IdcatBrevete
                });
            }catch(System.Exception){
                throw;
            }
            return result;
        }
        public Brevete Get(int id){
            var result = new Brevete();
            try
            {
                result = context.Brevetes.Single(x=>x.Id == id);
            }
            catch (System.Exception)
            {
                
                throw;
            }
            return result;
        }
    }
}