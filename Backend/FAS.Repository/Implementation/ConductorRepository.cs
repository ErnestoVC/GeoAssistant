using System.Collections;
using System.Collections.Generic;
using System.Linq;
using FAS.Entity;
using FAS.Repository.Context;
using Microsoft.EntityFrameworkCore;

namespace FAS.Repository.Implementation
{
    public class ConductorRepository : IConductorRepository
    {
        private ApplicationDbContext context;
        public ConductorRepository(ApplicationDbContext context){
            this.context=context;
        }

        public bool Delete(int id)
        {
            try
            {
                var result = new Conductor();
                result = context.Conductores.Single(x=>x.Id == id);
                context.Remove(result);
                context.SaveChanges();
            }
            catch (System.Exception)
            {
                
                return false;
            }
            return true; 
        }

        public IEnumerable fetchConductorByBrevete(string numero)
        {
            var result = new List<Conductor>();
            try
            {
                result = context.Conductores.Where(x=>x.Brevete.numero.Contains(numero)).ToList();
            }
            catch (System.Exception)
            {
                
                throw;
            }
            return result;
        }

        public IEnumerable fetchConductorbyDNI(string dni)
        {
            var result = new List<Conductor>();
            try
            {
                result = context.Conductores.Where(x=>x.Trabajador.DNI.Contains(dni)).ToList();
            }
            catch (System.Exception)
            {
                
                throw;
            }
            return result;
        }

        public IEnumerable fetchConductorByName(string nombre)
        {
            var result = new List<Conductor>();
            try
            {
                result = context.Conductores.Where(x=>x.Trabajador.Nombres.Contains(nombre)).ToList();
            }
            catch (System.Exception)
            {
                
                throw;
            }
            return result;
        }

        public Conductor Get(int id)
        {
            var result = new Conductor();
            try
            {
                result = context.Conductores.Single(x=>x.Id == id);
            }
            catch (System.Exception)
            {
                
                throw;
            }
            return result;
        }

        public IEnumerable<Conductor> GetAll()
        {
            var result = new List<Conductor>();
            try
            {
                result = context.Conductores.Include(c=>c.Brevete).Include(c=>c.Trabajador).ToList();
                result.Select(c=> new Conductor{
                    Id = c.Id,
                    IdBrevete = c.IdBrevete,
                    IdTrabajador = c.IdTrabajador
                });
            }
            catch (System.Exception)
            {
                
                throw;
            }
            return result;
        }

        public bool Save(Conductor e)
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

        public bool Update(Conductor e)
        {
            try
            {
                var origen = context.Conductores.Single(x=>x.Id == e.Id);
                origen.Id = e.Id;
                origen.IdBrevete = e.IdBrevete;
                origen.IdTrabajador = e.IdTrabajador;

                context.Update(origen);
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