using System.Collections;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using FAS.Entity;
using FAS.Repository.Context;

namespace FAS.Repository.Implementation
{
    public class VehiculoRepository : IVehiculoRepository
    {
        private ApplicationDbContext context;

        public VehiculoRepository(ApplicationDbContext context){
            this.context=context;
        }
        public bool Delete(int id)
        {
            try
            {
                var result = new Vehiculo();
                result = context.Vehiculos.Single(x=>x.Id == id);
                context.Remove(result);
                context.SaveChanges();
            }
            catch (System.Exception)
            {
                
                return false;
            }
            return true;
        }

        public IEnumerable fetchVehiculobyPlaca(string placa)
        {
            var result = new List<Vehiculo>();
            try
            {
                result = context.Vehiculos.Where(m=>m.placa.Contains(placa)).ToList();
            }
            catch (System.Exception)
            {
                
                throw;
            }
            return result;
        }

        public Vehiculo Get(int id)
        {
            var result = new Vehiculo();
            try
            {
                result = context.Vehiculos.Single(x=>x.Id == id);
            }
            catch (System.Exception)
            {
                
                throw;
            }
            return result;
        }

        public IEnumerable<Vehiculo> GetAll()
        {
            var result = new List<Vehiculo>();
            try
            {
                result = context.Vehiculos.Include(c=>c.Modelo).ToList();
                result.Select(c=> new Vehiculo{
                    Id = c.Id,
                    nromotor = c.nromotor,
                    placa = c.placa,
                    estadomotor = c.estadomotor,
                    IdModelo = c.IdModelo
                });
            }
            catch (System.Exception)
            {
                
                throw;
            }
            return result;
        }

        public bool Save(Vehiculo e)
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

        public bool Update(Vehiculo e)
        {
            try
            {
                var original = context.Vehiculos.Single(x=>x.Id == e.Id);
                original.Id = e.Id;
                original.nromotor = e.nromotor;
                original.placa = e.placa;
                original.estadomotor = e.estadomotor;
                original.IdModelo = e.IdModelo;

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