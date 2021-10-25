using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
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
            app = new VeterinariaApp();
        }

        [HttpGet]
        public IActionResult GetTipoMascotas() {

            return Ok(app.ConsultarTipoMascotas());

        }
    }
}
