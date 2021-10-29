using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VeterinariaBack.dominio;
using VeterinariaBack.services;

namespace VeterinariaWebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AtencionesController : ControllerBase
    {
        public IVeterinariaApp app;

        public AtencionesController()
        {
            app = new ServiceFactoryImpl().CrearService();
        }
        
        [HttpGet]
        public IActionResult GetUltimoIdAtencion() {

            return Ok(app.ConsultarUltimoIdAtencion());
        }
        
    
        [HttpPost("all")]
        public IActionResult PostAtenciones(Mascota oMascota)
        {
            return Ok(app.ConsultarAtenciones(oMascota));
        }
        
        [HttpPost]
        public IActionResult PostGuardarAtencion(Mascota oMascota)
        {
            return Ok(app.GuardarAtencion(oMascota));
        }

        [HttpPost("update")]
        public IActionResult PostUpdateAtenciones(Atencion oAtencion)
        {
            return Ok(app.EditarAtencion(oAtencion));
        }

        [HttpPost("delete")]
        public IActionResult PostDeleteAtenciones(Atencion oAtencion)
        {
            return Ok(app.EliminarAtencion(oAtencion));
        }
    }
}
