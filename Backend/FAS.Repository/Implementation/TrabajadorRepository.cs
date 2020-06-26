using System.Collections.Generic;
using System.Linq;
using FAS.Entity;
using FAS.Repository.Context;
using Microsoft.EntityFrameworkCore;

namespace FAS.Repository.Implementation
{
    public class TrabajadorRepository : ITrabajadorRepository
    {
        private ApplicationDbContext context;
        public TrabajadorRepository(ApplicationDbContext context){
            this.context=context;
        }

        public bool Delete(int id)
        {
            try
            {
                var result = new Trabajador();
                result = context.Trabajadores.Single(x=>x.Id == id);
                context.Remove(result);
                context.SaveChanges();
            }
            catch (System.Exception)
            {
                
                return false;
            }
            return true;
        }

        public Trabajador Get(int id)
        {
            var result = new Trabajador();
            try
            {
                result = context.Trabajadores.Single(x=>x.Id == id);
            }
            catch (System.Exception)
            {
                
                throw;
            }
            return result;
        }

        public IEnumerable<Trabajador> GetAll()
        {
            var result = new List<Trabajador>();
            try{
                result = context.Trabajadores.Include(c=>c.Usuario).ToList();
                result.Select(c=> new Trabajador{
                    Id = c.Id,
                    Nombres = c.Nombres,
                    Apellidos = c.Apellidos,
                    Correo = c.Correo,
                    Celular = c.Celular,
                    DNI = c.DNI,
                    IdUsuario = c.IdUsuario
                });
            }catch(System.Exception){
                throw;
            }
            return result;
        }

        public bool Save(Trabajador e)
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

        public bool Update(Trabajador e)
        {
            try
            {
                var origen = context.Trabajadores.Single(x=>x.Id == e.Id);
                origen.Id = e.Id;
                origen.Nombres = e.Nombres;
                origen.Apellidos = e.Apellidos;
                origen.Correo = e.Correo;
                origen.Celular = e.Celular;
                origen.DNI = e.DNI;
                origen.IdUsuario = e.IdUsuario;
            }
            catch (System.Exception)
            {
                
                return false;
            }
            return true;
        }
    }
}