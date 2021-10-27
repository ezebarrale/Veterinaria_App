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
        public bool ConsultarUsuario(string usr, string pass)
        {
            return dao.Login(usr, pass);
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
    }
}
