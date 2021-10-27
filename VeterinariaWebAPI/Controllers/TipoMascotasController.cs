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
    public class TipoMascotasController : ControllerBase
    {
        private IVeterinariaApp app;

        public TipoMascotasController()
        {
            app = new ServiceFactoryImpl().CrearService();
        }

        [HttpGet]
        public IActionResult GetTipoMascotas() {

            return Ok(app.ConsultarTipoMascotas());

        }

        [HttpPost]
        public IActionResult PostTipoMascota(TipoMascota tm) {

            if (String.IsNullOrEmpty(tm.Nombre))
                return BadRequest();
            else 
                return Ok(app.GuardarTipoMascota(tm.Nombre));

        }

        [HttpPut]
        public IActionResult PutTipoMascota(TipoMascota oTm) {

            if (app.EliminarTipoMascota(oTm))
                return Ok("Tipo de mascota eliminada con exito");
            else
                return BadRequest();
        }
    }
}
