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
        public bool ConsultarUsuario(Usuario oUsuario);
        public List<TipoMascota> ConsultarTipoMascotas();
        public TipoMascota GuardarTipoMascota(string description);
        public bool EliminarTipoMascota(TipoMascota oTm);
        public bool EditarTipoMascota(TipoMascota oTm);
        public List<Cliente> ConsultarClientes(string nombre);
        public List<Mascota> ConsultarMascotas(int id_cliente);
        public Atencion ConsultarUltimoIdAtencion();
        public bool GuardarAtencion(Mascota oMascota);
        public List<Atencion> ConsultarAtenciones(Mascota oMascota);
        public bool EditarAtencion(Atencion oAtencion);
        public bool EliminarAtencion(Atencion oAtencion);
        public bool EditarCliente(Cliente oCliente);
        public bool EliminarCliente(Cliente oCliente);
        public bool EditarMascota(Mascota oMascota);
        public bool EliminarMascota(Mascota oMascota);
    }
}
