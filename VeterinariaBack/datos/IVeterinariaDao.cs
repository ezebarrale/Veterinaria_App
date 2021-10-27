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
        bool Login(Usuario oUsuario);
        List<TipoMascota> GetTipoMascota();
        TipoMascota SaveTipoMascota(string descripcion);
        bool DeleteTipoMascota(TipoMascota oTm);
        bool UpdateTipoMascota(TipoMascota oTm);
    }
}
