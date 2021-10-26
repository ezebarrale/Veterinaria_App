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
    public class AccessController : ControllerBase
    {
        IVeterinariaApp app;

        public AccessController()
        {
            app = new VeterinariaApp();
        }

        [HttpGet]
        public IActionResult GetUser(string usr, string pass) {
            if (app.ConsultarUsuario(usr, pass))
                return Ok(app.ConsultarUsuario(usr, pass));
            else
                return NotFound(app.ConsultarUsuario(usr, pass));
        }
    }
}
