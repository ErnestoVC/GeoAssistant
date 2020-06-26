using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using FAS.Entity;
using FAS.Repository.Context;

namespace FAS.Repository.Implementation
{
    public class UsuarioRepository : IUsuarioRepository
    {
        private ApplicationDbContext context;
        public UsuarioRepository(ApplicationDbContext context)        {
            this.context=context;
        }

        public bool Delete(int id)
        {
            try
            {
                var result = new Usuarios();
                result = context.Usuarios.Single(x=>x.Id == id);
                context.Remove(result);
                context.SaveChanges();
            }
            catch (System.Exception)
            {
                
                return false;
            }
            return true;
        }

        public Usuarios Get(int id)
        {
            var result = new Usuarios();
            try
            {
                result = context.Usuarios.Single(x=>x.Id == id);
            }
            catch (System.Exception)
            {
                
                throw;
            }
            return result;
        }

        public IEnumerable<Usuarios> GetAll()
        {
            var result = new List<Usuarios>();
            try
            {
                result = context.Usuarios.ToList();
            }
            catch (System.Exception)
            {
                
                throw;
            }
            return result;
        }

        public bool Save(Usuarios e)
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

        public bool Update(Usuarios e)
        {
            try
            {
                var original = context.Usuarios.Single(x=>x.Id == e.Id);
                original.Id = e.Id;
                original.usuario = e.usuario;
                original.contraseña = e.contraseña;

                context.Update(original);
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