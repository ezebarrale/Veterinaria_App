using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
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

    }
}
