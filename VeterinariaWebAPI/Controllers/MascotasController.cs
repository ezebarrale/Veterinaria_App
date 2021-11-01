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

        [HttpGet]
        public IActionResult GetMascotas(int id_cliente)
        {
            return Ok(app.ConsultarMascotas(id_cliente));
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
