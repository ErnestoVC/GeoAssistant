using System.Collections;
using System.Collections.Generic;
using System.Linq;
using FAS.Entity;
using FAS.Repository.Context;

namespace FAS.Repository.Implementation
{
    public class CatBreveteRepository : ICatBreveteRepository
    {
        private ApplicationDbContext context;

        public CatBreveteRepository(ApplicationDbContext context){
            this.context=context;
        }

        public bool Save (CatBrevete e){
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
        public bool Update (CatBrevete e){
            try
            {
                var original = context.CatBrevetes.Single(x=>x.Id == e.Id);
                original.Id = e.Id;
                original.catbrevete = e.catbrevete;

                context.Update(original);
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
               var result = new CatBrevete();
               result = context.CatBrevetes.Single(x=>x.Id == id);
               context.Remove(result);
               context.SaveChanges();
            }
            catch (System.Exception)
            {
                
                return false;
            }
            return true;
        }
        public IEnumerable<CatBrevete> GetAll(){
            var result = new List<CatBrevete>();
            try{
                result = context.CatBrevetes.ToList();
            }catch(System.Exception){
                throw;
            }
            return result;
        }
        public CatBrevete Get(int id){
            var result = new CatBrevete();
            try
            {
                result = context.CatBrevetes.Single(x=>x.Id == id);
            }
            catch (System.Exception)
            {
                
                throw;
            }
            return result;
        }
    }
}