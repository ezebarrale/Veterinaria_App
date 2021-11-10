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
        public IActionResult GetUser(Usuario usr)
        {
            Usuario oUsuario = app.ConsultarUsuario(usr);
            if (oUsuario != null)
                return Ok(oUsuario);
            else
                return NotFound("No existe el usuario ingresado");

        }

        [HttpPost("save")]
        public IActionResult PostUsersave(Usuario usr)
        {
            if (app.GuardarUsuario(usr))
                return Ok();
            else
                return BadRequest();

        }

        [HttpPost("users")]
        public IActionResult GetUsers(Usuario usr)
        {
            return Ok(app.ConsultarUsuarios(usr));

        }

        [HttpPost("delete")]
        public IActionResult PostRemoveUser(Usuario usr)
        {
            bool exito = app.EliminarUsuario(usr);
            if (exito)
                return Ok(exito);
            else
                return BadRequest(exito);

        }

        [HttpPost("update")]
        public IActionResult PostUpdateUser(Usuario usr)
        {
            bool exito = app.EditarUsuario(usr);
            if (exito)
                return Ok(exito);
            else
                return BadRequest(exito);

        }
    }
}
