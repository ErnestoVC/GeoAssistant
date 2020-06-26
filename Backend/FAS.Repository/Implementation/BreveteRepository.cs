using System.Collections;
using System.Collections.Generic;
using System.Linq;
using FAS.Entity;
using FAS.Repository.Context;
using Microsoft.EntityFrameworkCore;

namespace FAS.Repository.Implementation
{
    public class BreveteRepository : IRepository<Brevete>
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
            throw new System.NotImplementedException();
        }
        public bool Delete(int id){
            throw new System.NotImplementedException();
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