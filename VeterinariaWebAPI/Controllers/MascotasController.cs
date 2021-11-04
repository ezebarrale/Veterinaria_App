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
    public class MascotasController : ControllerBase
    {
        private IVeterinariaApp app;

        public MascotasController()
        {
            app = new ServiceFactoryImpl().CrearService();
        }

        [HttpPost("idCliente")]
        public IActionResult GetMascotas(Cliente oCliente)
        {
            return Ok(app.ConsultarMascotas(oCliente.Codigo));
        }

        [HttpGet("id")]
        public IActionResult GetNextIdMascotas()
        {
            return Ok(app.ConsultarSiguienteIdMascota());
        }

        [HttpPost("save")]
        public IActionResult PostSaveMascotas(Cliente oCliente)
        {
            bool result = app.GuardarMascota(oCliente);
            if (result)
                return Ok(result);
            else
                return BadRequest(result);
        }

        [HttpPost("update")]
        public IActionResult PostUpdateMascotas (Mascota oMascota)
        {
            return Ok(app.EditarMascota(oMascota));
        }

        [HttpPost("delete")]
        public IActionResult PostDeleteMascotas(Mascota oMascota)
        {
            return Ok(app.EliminarMascota(oMascota));
        }
    }
}
