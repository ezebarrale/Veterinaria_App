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
    public class ClientesController : ControllerBase
    {
        private IVeterinariaApp app;

        public ClientesController()
        {
            app = new ServiceFactoryImpl().CrearService();
        }

        [HttpGet("id")]
        public IActionResult GetNextIdCliente()
        {
            int id = app.ConsultarSiguienteIdCliente();
            if (id == 0)
            {
                return BadRequest();
            }
            else {
                return Ok(id);
            }

        }

        [HttpGet("nombre/{nombre}")]
        public IActionResult GetClientes(string nombre) {

            return Ok(app.ConsultarClientes(nombre));

        }

        [HttpPost("save")]
        public IActionResult PostSaveClientes(Cliente oCliente)
        {

            return Ok(app.GuardarCliente(oCliente));

        }

        [HttpPost("update")]
        public IActionResult PostUpdateClientes(Cliente oCliente)
        {

            return Ok(app.EditarCliente(oCliente));

        }

        [HttpPost("delete")]
        public IActionResult PostDeleteClientes(Cliente oCliente)
        {

            return Ok(app.EliminarCliente(oCliente));

        }
    }
}
