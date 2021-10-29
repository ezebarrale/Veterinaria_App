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
        public bool ConsultarUsuario(Usuario oUsuario)
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
        public List<Cliente> ConsultarClientes(string nombre)
        {
            return dao.GetClientes(nombre);
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
    }
}
