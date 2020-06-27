using FAS.Entity;
using FAS.Service;
using Microsoft.AspNetCore.Mvc;

namespace FAS.Api.Controllers
{
    public class VehiculoController : ControllerBase
    {
        private IVehiculoService conSer;

        protected VehiculoController(IVehiculoService conSer)
        {
            this.conSer=conSer;
        }
        
        [HttpGet]
        public ActionResult GetAll(){
            return Ok(
                conSer.GetAll()
            );
        }

        [HttpGet("{id}")]
        public ActionResult Get([FromRoute] int id){
            return Ok(
                conSer.Get(id)
            );
        }

        [HttpPut]
        public ActionResult Update([FromRoute] Vehiculo cl){
            return Ok(
                conSer.Update(cl)
            );
        }

        [HttpDelete("{id}")]
        public ActionResult Delete(int id){
            return Ok(
                conSer.Delete(id)
            );
        }

        [HttpPost]
        public ActionResult Crear([FromBody] Vehiculo cl){
            return Ok(
                conSer.Save(cl)
            );
        }

        [HttpGet("{placa}")]
        public ActionResult fetchVehiculobyPlaca([FromRoute] string placa){
            return Ok(
                conSer.fetchVehiculobyPlaca(placa)
            );
        }
    }
}