using System.Collections;
using System.Collections.Generic;
using System.Linq;
using FAS.Entity;
using FAS.Repository.Context;
using Microsoft.EntityFrameworkCore;

namespace  FAS.Service.Implementacion
{
    public class UsuarioServivce : IUsuarioService
    {
        private IUsuarioRespository  clRepos;
        
        public BreveteService(IUsuarioRespository clRepos)
        {
            this.clRepos=clRepos;
        }

        public bool Save(Usuario e)
        {
            return clRepos.Save(e);
        }
        public bool Update(Usuario e)
        {
            return clRepos.Update(e);
        }

        public bool Delete(int id)
        {
            return clRepos.Delete(id);
        }
         
        public IEnumerable<Usuario> GetAll()
        {
            return clRepos.GetAll();
        }
         
        public Usuario Get(int id)
        {
            return clRepos.Get(id);
        }
    }
}