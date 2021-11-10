using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VeterinariaBack.dominio;
using VeterinariaBack.datos;

namespace VeterinariaBack.services
{
    public class VeterinariaApp : IVeterinariaApp
    {
        private IVeterinariaDao dao;

        public VeterinariaApp()
        {
            dao = new VeterinariaDao();
        }
        public Usuario ConsultarUsuario(Usuario oUsuario)
        {
            return dao.Login(oUsuario);
        }
        public List<TipoMascota> ConsultarTipoMascotas()
        {
            return dao.GetTipoMascota();
        }
        public TipoMascota GuardarTipoMascota(string description)
        {
            return dao.SaveTipoMascota(description);
        }
        public bool EliminarTipoMascota(TipoMascota oTm)
        {
            return dao.DeleteTipoMascota(oTm);
        }
        public bool EditarTipoMascota(TipoMascota oTm)
        {
            return dao.UpdateTipoMascota(oTm);
        }
        public List<Cliente> ConsultarClientes(Cliente oCliente)
        {
            return dao.GetClientes(oCliente);
        }
        public List<Mascota> ConsultarMascotas(int id_cliente)
        {
            return dao.GetMascotas(id_cliente);
        }
        public Atencion ConsultarUltimoIdAtencion()
        {
            return dao.GetUltimoIdAtencion();
        }
        public bool GuardarAtencion(Mascota oMascota)
        {
            return dao.SaveAtencion(oMascota);
        }
        public List<Atencion> ConsultarAtenciones(Mascota oMascota)
        {
            return dao.GetAtenciones(oMascota);
        }
        public bool EditarAtencion(Atencion oAtencion)
        {
            return dao.UpdateAtencion(oAtencion);
        }
        public bool EliminarAtencion(Atencion oAtencion)
        {
            return dao.DeleteAtencion(oAtencion);
        }
        public bool EditarCliente(Cliente oCliente)
        {
            return dao.UpdateCliente(oCliente);
        }
        public bool EliminarCliente(Cliente oCliente)
        {
            return dao.DeleteCliente(oCliente);
        }
        public bool EditarMascota(Mascota oMascota)
        {
            return dao.UpdateMascota(oMascota);
        }
        public bool EliminarMascota(Mascota oMascota)
        {
            return dao.DeleteMascota(oMascota);
        }
        public int ConsultarSiguienteIdCliente()
        {
            return dao.GetNextIdCliente();
        }
        public bool GuardarCliente(Cliente oCliente)
        {
            return dao.SaveCliente(oCliente);
        }
        public int ConsultarSiguienteIdMascota()
        {
            return dao.GetNextIdMascota();
        }
        public bool GuardarMascota(Cliente oCliente)
        {
            return dao.SaveMascota(oCliente);
        }
        public List<Veterinario> ConsultarVeterinarios()
        {
            return dao.GetVeterinarios();
        }
        public List<DetalleAtencion> ConsultarDetallesAtencion(Atencion oAtencion)
        {
            return dao.GetDetallesAtencion(oAtencion);
        }

        public Cliente ConsultarClientesXDni(Cliente oCliente)
        {
            return dao.GetClienteByDni(oCliente);
        }

        public bool GuardarUsuario(Usuario oUsuario)
        {
            return dao.InsertUsuario(oUsuario);
        }

        public List<Usuario> ConsultarUsuarios(Usuario oUsuario)
        {
            return dao.GetUsuarios(oUsuario);
        }

        public bool EliminarUsuario(Usuario oUsuario)
        {
            return dao.DeleteUsuario(oUsuario);
        }

        public bool EditarUsuario(Usuario oUsuario)
        {
            return dao.UpdateUsuario(oUsuario);
        }

        public int ConsultarSiguienteIdVeterinario()
        {
            return dao.GetNextIdVeterinario();
        }

        public bool EditarVeterinario(Veterinario oVeterinario)
        {
            return dao.UpdateVeterinario(oVeterinario);
        }

        public bool EliminarVeterinario(Veterinario oVeterinario)
        {
            return dao.DeleteVeterinario(oVeterinario);
        }

        public Veterinario ConsultarVeterinariosXDni(Veterinario oVeterinario)
        {
            return dao.GetVeterinarioByDni(oVeterinario);
        }

        public bool GuardarVeterinario(Veterinario oVeterinario)
        {
            return dao.SaveVeterinario(oVeterinario);
        }
    }
}
