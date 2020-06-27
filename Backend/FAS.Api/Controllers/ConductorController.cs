using FAS.Entity;
using FAS.Service;
using Microsoft.AspNetCore.Mvc;

namespace FAS.Api.Controllers
{
    public class ConductorController : ControllerBase
    {
        private IConductorService conSer;

        protected ConductorController(IConductorService conSer)
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
        public ActionResult Update([FromRoute] Conductor cl){
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
        public ActionResult Crear([FromBody] Conductor cl){
            return Ok(
                conSer.Save(cl)
            );
        }

        [HttpGet("{nombre}")]
        public ActionResult fetchConductorByName([FromRoute] string nombre){
            return Ok(
                conSer.fetchConductorByName(nombre)
            );
        }

        [HttpGet("{dni}")]
        public ActionResult fetchConductorbyDNI([FromRoute] string dni){
            return Ok(
                conSer.fetchConductorbyDNI(dni)
            );
        }

        [HttpGet("{numero}")]
        public ActionResult fetchConductorByBrevete([FromRoute] string numero){
            return Ok(
                conSer.fetchConductorbyDNI(numero)
            );
        }
    }
}