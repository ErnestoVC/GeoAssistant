using FAS.Entity;
using FAS.Service;
using Microsoft.AspNetCore.Mvc;

namespace FAS.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ModeloController : ControllerBase
    {
        private IModeloService conSer;

        public ModeloController(IModeloService conSer)
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
        public ActionResult Update([FromRoute] Modelo cl){
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
        public ActionResult Crear([FromBody] Modelo cl){
            return Ok(
                conSer.Save(cl)
            );
        }
    }
}