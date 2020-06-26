using System.Collections.Generic;
using System.Linq;
using FAS.Entity;
using FAS.Repository.Context;
using FAS.Repository.viewModel;
using Microsoft.EntityFrameworkCore;

namespace FAS.Repository.Implementation
{
    public class ViajeRepository : IViajeRepository
    {
        private ApplicationDbContext context;
        public ViajeRepository(ApplicationDbContext context){
            this.context=context;
        }

        public bool Delete(int id)
        {
            throw new System.NotImplementedException();
        }

        public Viaje Get(int id)
        {
            throw new System.NotImplementedException();
        }

        public IEnumerable<Viaje> GetAll()
        {
            throw new System.NotImplementedException();
        }

        public IEnumerable<ViajeViewModel> GetAllViajes()
        {
            var viajes =  context.Viajes
            .Include(o=>o.Conductor)
            .Include(o=>o.Vehiculo)
            .OrderByDescending(o=>o.Id)
            .Take(10)
            .ToList();

            return viajes.Select(o=> new ViajeViewModel {
                Id = o.Id,
                nroViaje = o.nroViaje,
                fechaviaje = o.fechaviaje,
                TipoCarga = o.TipoCarga,
                NombreConductor = o.Conductor.Trabajador.Nombres,
                brevete = o.Conductor.Brevete.numero,
                modelo = o.Vehiculo.Modelo.modelo,
                placa = o.Vehiculo.placa

            });
        }

        public IEnumerable<DetalleViajeViewModel> ListarDetalles(int viajeId)
        {
            var detalle = context.DetalleViajes
            .Include(m=>m.Asistencia)
            .Where(d=>d.IdViaje == viajeId)
            .ToList();
            
            return detalle.Select(c=> new DetalleViajeViewModel {
                ViajeId = c.IdViaje,
                AsistenciaId = c.IdAsistencia,
                Fecha = c.Asistencia.fecha,
                posX = c.Asistencia.posX,
                posY = c.Asistencia.posY
            });
        }

        public bool Save(Viaje e)
        {
            Viaje viaje = new Viaje{
                nroViaje = e.nroViaje,
                fechaviaje = e.fechaviaje,
                TipoCarga = e.TipoCarga,
                IdConductor = e.IdConductor,
                IdVehiculo = e.IdVehiculo                
            };

            try
            {
                context.Viajes.Add(viaje);
                context.SaveChanges();
                var viajeid = viaje.Id;
                foreach(var item in e.DetalleViaje){
                    DetalleViaje detalle = new DetalleViaje{
                        IdViaje = viajeid,
                        IdAsistencia = item.IdAsistencia                        
                    };
                    context.DetalleViajes.Add(detalle);
                }
            }
            catch (System.Exception)
            {
                
                return false;
            }
            return true;
        }

        public bool Update(Viaje e)
        {
            throw new System.NotImplementedException();
        }
    }
}