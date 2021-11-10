using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VeterinariaBack.dominio;

namespace VeterinariaBack.datos
{
    interface IVeterinariaDao
    {
        Usuario Login(Usuario oUsuario);
        List<TipoMascota> GetTipoMascota();
        TipoMascota SaveTipoMascota(string descripcion);
        bool DeleteTipoMascota(TipoMascota oTm);
        bool UpdateTipoMascota(TipoMascota oTm);
        List<Cliente> GetClientes(Cliente oCliente);
        public Cliente GetClienteByDni(Cliente oCliente);
        int GetNextIdCliente();
        int GetNextIdMascota();
        List<Mascota> GetMascotas(int id_cliente);
        Atencion GetUltimoIdAtencion();
        bool SaveAtencion(Mascota oMascota);
        List<Atencion> GetAtenciones(Mascota oMascota);
        bool UpdateAtencion(Atencion oAtencion);
        bool DeleteAtencion(Atencion oAtencion);
        bool SaveCliente(Cliente oCliente);
        bool UpdateCliente(Cliente oCliente);
        bool DeleteCliente(Cliente oCliente);
        bool SaveMascota(Cliente oCliente);
        bool UpdateMascota(Mascota oMascota);
        bool DeleteMascota(Mascota oMascota);
        List<Veterinario> GetVeterinarios();
        List<DetalleAtencion> GetDetallesAtencion(Atencion oAtencion);
        bool InsertUsuario(Usuario oUsuario);
        List<Usuario> GetUsuarios(Usuario oUsuario);
        bool DeleteUsuario(Usuario oUsuario);
        bool UpdateUsuario(Usuario oUsuario);

    }
}
