using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Veterinaria_Form.dominio;

namespace VeterinariaBack.datos
{
    interface IVeterinariaDao
    {
        bool Login(string usr, string pass);
        List<TipoMascota> GetTipoMascota();
    }
}
