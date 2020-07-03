using System.Collections;
using System.Collections.Generic;
using System.Linq;
using FAS.Entity;
using FAS.Repository.Context;
using Microsoft.EntityFrameworkCore;
using FAS.Repository;

namespace  FAS.Service.Implementacion
{
    public class UsuarioServivce : IUsuarioService
    {
        private IUsuarioRepository  clRepos;
        
        public UsuarioServivce(IUsuarioRepository clRepos)
        {
            this.clRepos=clRepos;
        }

        public bool Delete(int id)
        {
            return clRepos.Delete(id);
        }

        public IEnumerable fetchUsuariobyUsername(string username)
        {
            return clRepos.fetchUsuariobyUsername(username);
        }

        public Usuarios Get(int id)
        {
            return clRepos.Get(id);
        }

        public IEnumerable<Usuarios> GetAll()
        {
            return clRepos.GetAll();
        }

        public bool Save(Usuarios e)
        {
            return clRepos.Save(e);
        }

        public bool Update(Usuarios e)
        {
            return clRepos.Update(e);
        }
    }
}