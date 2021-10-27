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
    public class AccessController : ControllerBase
    {
        IVeterinariaApp app;

        public AccessController()
        {
            app = new ServiceFactoryImpl().CrearService();
        }

        [HttpPost]
        public IActionResult PostUser(Usuario usr)
        {
            bool exito = app.ConsultarUsuario(usr);
            if (exito)
                return Ok(exito);
            else
                return NotFound("No existe el usuario ingresado");

        }
    }
}
