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
    }
}
