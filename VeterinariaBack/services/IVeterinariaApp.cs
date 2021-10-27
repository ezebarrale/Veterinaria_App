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
    }
}
