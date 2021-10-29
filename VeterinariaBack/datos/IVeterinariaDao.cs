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
        List<Cliente> GetClientes(string nombre);
        List<Mascota> GetMascotas(int id_cliente);
        Atencion GetUltimoIdAtencion();
        bool SaveAtencion(Mascota oMascota);
        List<Atencion> GetAtenciones(Mascota oMascota);
        bool UpdateAtencion(Atencion oAtencion);
        bool DeleteAtencion(Atencion oAtencion);
    }
}
