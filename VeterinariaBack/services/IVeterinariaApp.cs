using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VeterinariaBack.dominio;

namespace VeterinariaBack.services
{
    public interface IVeterinariaApp
    {
        public Usuario ConsultarUsuario(Usuario oUsuario);
        public List<TipoMascota> ConsultarTipoMascotas();
        public TipoMascota GuardarTipoMascota(string description);
        public bool EliminarTipoMascota(TipoMascota oTm);
        public bool EditarTipoMascota(TipoMascota oTm);
        public List<Cliente> ConsultarClientes(Cliente oCliente);
        public Cliente ConsultarClientesXDni(Cliente oCliente);
        public int ConsultarSiguienteIdCliente();
        public int ConsultarSiguienteIdMascota();
        public List<Mascota> ConsultarMascotas(int id_cliente);
        public Atencion ConsultarUltimoIdAtencion();
        public bool GuardarAtencion(Mascota oMascota);
        public List<Atencion> ConsultarAtenciones(Mascota oMascota);
        public bool EditarAtencion(Atencion oAtencion);
        public bool EliminarAtencion(Atencion oAtencion);
        public bool GuardarCliente(Cliente oCliente);
        public bool EditarCliente(Cliente oCliente);
        public bool EliminarCliente(Cliente oCliente);
        public bool GuardarMascota(Cliente oCliente);
        public bool EditarMascota(Mascota oMascota);
        public bool EliminarMascota(Mascota oMascota);
        public List<Veterinario> ConsultarVeterinarios();
        public List<DetalleAtencion> ConsultarDetallesAtencion(Atencion oAtencion);
        public bool GuardarUsuario(Usuario oUsuario);
        public List<Usuario> ConsultarUsuarios(Usuario oUsuario);
        public bool EliminarUsuario(Usuario oUsuario);
        public bool EditarUsuario(Usuario oUsuario);
    }
}
