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

        public bool Delete (int id){
            throw new System.NotImplementedException();
        }
        
    }
}