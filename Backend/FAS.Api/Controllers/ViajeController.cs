using FAS.Entity;
using FAS.Service;
using Microsoft.AspNetCore.Mvc;

namespace FAS.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ViajeController : ControllerBase
    {
         private IViajeService conSer;

        public ViajeController(IViajeService conSer)
        {
            this.conSer=conSer;
        }
        
        [HttpGet]
        public ActionResult GetAll(){
            return Ok(
                conSer.GetAllViajes()
            );
        }

        [HttpGet("{asistenciaid}")]
        public ActionResult Get([FromRoute] int asistenciaid){
            return Ok(
                conSer.ListarDetalles(asistenciaid)
            );
        }

        [HttpPut]
        public ActionResult Update([FromRoute] Viaje cl){
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
        public ActionResult Crear([FromBody] Viaje cl){
            return Ok(
                conSer.Save(cl)
            );
        }
    }
}