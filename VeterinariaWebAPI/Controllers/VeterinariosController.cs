using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VeterinariaBack.dominio;
using VeterinariaBack.services;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace VeterinariaWebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class VeterinariosController : ControllerBase
    {
        IVeterinariaApp app;

        public VeterinariosController()
        {
            app = new ServiceFactoryImpl().CrearService();
        }

        [HttpGet]
        public IActionResult Getveterinarios()
        {
            return Ok(app.ConsultarVeterinarios());
        }

        [HttpGet("id")]
        public IActionResult GetveterinarioXId()
        {
            return Ok(app.ConsultarSiguienteIdVeterinario());
        }

        [HttpPost("save")]
        public IActionResult PostSaveVeterinario(Veterinario oVeterinario)
        {
            return Ok(app.GuardarVeterinario(oVeterinario));
        }

        [HttpPost("update")]
        public IActionResult PostUpdateVeterinario(Veterinario oVeterinario)
        {
            return Ok(app.EditarVeterinario(oVeterinario));
        }

        [HttpPost("delete")]
        public IActionResult PostDeleteVeterinario(Veterinario oVeterinario)
        {
            return Ok(app.EliminarVeterinario(oVeterinario));
        }

        [HttpPost("getByDni")]
        public IActionResult PostGetVeterinarioDni(Veterinario oVeterinario)
        {

            return Ok(app.ConsultarVeterinariosXDni(oVeterinario));

        }

    }
}
