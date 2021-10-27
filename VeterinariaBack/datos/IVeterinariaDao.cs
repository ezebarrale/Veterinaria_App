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
        bool Login(string usr, string pass);
        List<TipoMascota> GetTipoMascota();
        TipoMascota SaveTipoMascota(string descripcion);
        bool DeleteTipoMascota(TipoMascota oTm);
    }
}
