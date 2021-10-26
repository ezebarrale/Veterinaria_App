using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Veterinaria_Form.dominio;

namespace VeterinariaBack.services
{
    public interface IVeterinariaApp
    {
        public bool ConsultarUsuario(string usr, string pass);
        public List<TipoMascota> ConsultarTipoMascotas();
    }
}
