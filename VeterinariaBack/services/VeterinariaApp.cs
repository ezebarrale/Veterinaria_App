using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Veterinaria_Form.dominio;
using VeterinariaBack.datos;

namespace VeterinariaBack.services
{
    public class VeterinariaApp : IVeterinariaApp
    {
        private IVeterinariaDao dao;

        public VeterinariaApp()
        {
            dao = new VeterinariaDao(); //usar Factory
        }
        public bool ConsultarUsuario(string usr, string pass)
        {
            return dao.Login(usr, pass);
        }
        public List<TipoMascota> ConsultarTipoMascotas()
        {
            return dao.GetTipoMascota();
        }
    }
}
